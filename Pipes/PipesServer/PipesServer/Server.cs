using System;
using System.Text;
using System.Net;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pipes
{
    public partial class Server : Form
    {
        private Int32 pipeHandle;
        private Int32 pUser;
        private string pipeName;
        private Thread hThread;
        private bool _continue = true;
        private List<string> users;

        public Server()
        {
            InitializeComponent();

            pipeHandle = DIS.Import.CreateNamedPipe($@"\\.\pipe\ServerPipe", 
                         DIS.Types.PIPE_ACCESS_DUPLEX, 
                         DIS.Types.PIPE_TYPE_BYTE | DIS.Types.PIPE_WAIT, 
                         DIS.Types.PIPE_UNLIMITED_INSTANCES, 
                         0, 
                         1024, 
                         DIS.Types.NMPWAIT_WAIT_FOREVER, 
                         (uint)0
                         );
                     
            users = new List<string>();
            pipeName = $@"\\{Dns.GetHostName()}\pipe\ServerPipe";

            this.Text = $"     {pipeName}";
            
            hThread = new Thread(ReceiveMessage);
            hThread.Start();
        }

        // Получение сообщения от клиента
        private string GetMessage()
        {
            uint realBytesReaded = 0;

            byte[] buff = new byte[1024];
            DIS.Import.FlushFileBuffers(pipeHandle);
            DIS.Import.ReadFile(pipeHandle, buff, 1024, ref realBytesReaded, 0);
            string msg = Encoding.Unicode.GetString(buff);

            return msg;
        }

        // Рассылка сообщений пользователям чата
        private void SendUsersMessage(string msg, string name)
        {
            uint BytesWritten = 0;

            for (int i = 0; i < users.Count; i++)
            {
                BytesWritten = 0;
                if (!name.Equals(users[i]))
                {
                    byte[] buff = Encoding.Unicode.GetBytes(msg);

                    pUser = DIS.Import.CreateFile($@"\\.\pipe\{users[i]}", 
                            DIS.Types.EFileAccess.GenericWrite, 
                            DIS.Types.EFileShare.Read, 
                            0, 
                            DIS.Types.ECreationDisposition.OpenExisting, 
                            0, 
                            0
                            );
                    
                    if (pUser != -1)
                    {
                        DIS.Import.WriteFile(pUser, buff, Convert.ToUInt32(buff.Length), ref BytesWritten, 0);
                        DIS.Import.CloseHandle(pUser);
                    }
                    else
                    {
                        users.RemoveAt(i);
                        if (i >= 0) i--;
                    }
                }
            }
        }

        // Ожидание сообщений от клиентов
        private void ReceiveMessage()
        {
            string msg = string.Empty;

            while (_continue)
            {
                if (DIS.Import.ConnectNamedPipe(pipeHandle, 0))
                {
                    msg = GetMessage();

                    MessagesTB.Invoke((MethodInvoker)delegate
                    {
                        MessagesTB.Text += $@"{'\n'} >> {msg}";
                    });

                    string name = Regex.Match(msg, @"(.*?) >>").Groups[1].Value;
                    if (!users.Contains(name)) users.Add(name);

                    DIS.Import.DisconnectNamedPipe(pipeHandle);

                    SendUsersMessage(msg, name);
                    Thread.Sleep(500);
                }
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            _continue = false;

            if (hThread != null)
                hThread.Abort();

            Process id = Process.GetCurrentProcess();
            id.Kill();

            if (pipeHandle != -1)
                DIS.Import.CloseHandle(pipeHandle);
        }
    }
}