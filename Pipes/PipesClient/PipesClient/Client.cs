using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace Pipes
{
    public partial class Client : Form
    {
        private Int32 PipeHandle;
        private Int32 pUser;
        private bool newUser; 
        private bool _continue;
        private Thread hThread;

        public Client()
        {
            InitializeComponent();

            newUser = true;
            _continue = true;

            this.Text = $"     {Dns.GetHostName()}";
        }

        // Создание пользовательского канала
        private void CreateUserChannel()
        {
            if (newUser)
            {
                _continue = true;
                pUser = DIS.Import.CreateNamedPipe($@"\\.\pipe\{NicknameTB.Text}", 
                    DIS.Types.PIPE_ACCESS_DUPLEX, 
                    DIS.Types.PIPE_TYPE_BYTE | DIS.Types.PIPE_WAIT, 
                    DIS.Types.PIPE_UNLIMITED_INSTANCES, 
                    0, 
                    1024, 
                    DIS.Types.NMPWAIT_WAIT_FOREVER, 
                    (uint)0
                    );
                
                hThread = new Thread(ReceiveMessage);
                hThread.Start();
                
                newUser = false;
            }
        }

        // Отправка сообщения на сервер
        private void SendMessage()
        {
            MessagesTB.Text += $"Ваше сообщение: {MessageTB.Text}{Environment.NewLine}";

            uint BytesWritten = 0;
            byte[] buff = Encoding.Unicode.GetBytes($"{NicknameTB.Text} >> {MessageTB.Text}");

            PipeHandle = DIS.Import.CreateFile(ChannelNameTB.Text, 
                         DIS.Types.EFileAccess.GenericWrite, 
                         DIS.Types.EFileShare.Read, 
                         0, 
                         DIS.Types.ECreationDisposition.OpenExisting, 
                         0, 
                         0
                         );
            DIS.Import.WriteFile(PipeHandle, buff, Convert.ToUInt32(buff.Length), ref BytesWritten, 0);
            DIS.Import.CloseHandle(PipeHandle);
        }

        // Ожидание ответа сервера
        private void ReceiveMessage()
        {
            string msg = string.Empty;
            uint realBytesReaded = 0;

            while (_continue)
            {
                realBytesReaded = 0;

                if (DIS.Import.ConnectNamedPipe(pUser, 0))
                {
                    byte[] buff = new byte[1024];
                    DIS.Import.FlushFileBuffers(pUser);
                    DIS.Import.ReadFile(pUser, buff, 1024, ref realBytesReaded, 0);
                    msg = Encoding.Unicode.GetString(buff);

                    Invoke((MethodInvoker)delegate
                    {
                        MessagesTB.Text += $"{Encoding.Unicode.GetString(buff)}";
                        MessagesTB.Text += Environment.NewLine;
                    });

                    DIS.Import.DisconnectNamedPipe(pUser);
                    Thread.Sleep(500);
                }
            }
        }

        // Отключение пользователя от сервера
        private void DisconnectUser(bool mode)
        {
            newUser = true;
            _continue = false;

            if (hThread != null)
                hThread.Abort();

            if (mode)
            {
                Process id = Process.GetCurrentProcess();
                id.Kill();
            }

            if (pUser != -1)
                DIS.Import.CloseHandle(pUser);
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectUser(true);
        }

        private void SendMessbtn_Click(object sender, EventArgs e)
        {
            if (!NicknameTB.Text.Equals(string.Empty) &&
                !ChannelNameTB.Text.Equals(string.Empty) &&
                !MessageTB.Text.Equals(string.Empty))
            {

                CreateUserChannel();
                SendMessage();

                ChannelNameTB.Enabled = false;
                NicknameTB.Enabled = false;
            }
        }

        private void ChannelNameTB_TextChanged(object sender, EventArgs e)
        {
            DisconnectUser(false);
        }
    } 
}