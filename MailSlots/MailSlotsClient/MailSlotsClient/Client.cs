using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace MailSlots
{
    public partial class Client : Form
    {
        private Int32 handleMailSlot;
        private bool _continue = true;
        private Thread hThread;
        private Int32 pUser;

        public Client()
        {
            InitializeComponent();
            this.Text = $"     {Dns.GetHostName()}";
        }

        // Ожидание сообщений от сервера
        private void ReceiveMessage()
        {
            string msg = string.Empty;
            int MailslotSize = 0;
            int lpNextSize = 0;
            int MessageCount = 0;
            uint realBytesReaded = 0;

            while (_continue)
            {
                DIS.Import.GetMailslotInfo(pUser, MailslotSize, ref lpNextSize, ref MessageCount, 0);

                if (MessageCount > 0)
                    for (int i = 0; i < MessageCount; i++)
                    {
                        byte[] buff = new byte[1024];                           
                        DIS.Import.FlushFileBuffers(pUser);     
                        DIS.Import.ReadFile(pUser, buff, 1024, ref realBytesReaded, 0);      
                        msg = Encoding.Unicode.GetString(buff);

                        Invoke((MethodInvoker)delegate
                        {
                            MessagesTB.Text += msg;
                            MessagesTB.Text += Environment.NewLine;
                        });

                        Thread.Sleep(500);
                    }
            }
        }

        // Отправка сообщения на сервер
        private void SendMessage()
        {
            MessagesTB.Text += $"Ваше сообщение: {MessageTB.Text}{Environment.NewLine}";

            uint BytesWritten = 0;
            byte[] buff = Encoding.Unicode.GetBytes($"{LoginTB.Text} >> {MessageTB.Text}");
            DIS.Import.WriteFile(handleMailSlot, buff, Convert.ToUInt32(buff.Length), ref BytesWritten, 0);
        }

        private void SendMessBtn_Click(object sender, EventArgs e)
        {
            if (!MailSlotTB.Text.Equals(string.Empty) &&
                !LoginTB.Text.Equals(string.Empty) &&
                !MessageTB.Text.Equals(string.Empty))

                SendMessage();
        }

        // Подключение к серверу
        private void CreateConnection()
        {
            handleMailSlot = DIS.Import.CreateFile(MailSlotTB.Text, DIS.Types.EFileAccess.GenericWrite, DIS.Types.EFileShare.Read, 0, DIS.Types.ECreationDisposition.OpenExisting, 0, 0);

            if (handleMailSlot != -1)
            {
                ConnectBtn.Enabled = false;
                SendMessBtn.Enabled = true;

                pUser = DIS.Import.CreateMailslot($@"\\.\mailslot\{LoginTB.Text}",
                        0,
                        DIS.Types.MAILSLOT_WAIT_FOREVER,
                        0);

                hThread = new Thread(ReceiveMessage);
                hThread.Start();
            }
            else
                MessageBox.Show("Не удалось подключиться к мейлслоту");
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CreateConnection();
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к мейлслоту");
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            DIS.Import.CloseHandle(handleMailSlot);

            Process id = Process.GetCurrentProcess();
            id.Kill();
        }
    }
}