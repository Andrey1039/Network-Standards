using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MailSlots
{
    public partial class Server : Form
    {
        private int clientHandleMailSlot;
        private string mailSlotName;
        private Thread hThread;
        private bool _continue;
        private Int32 pUser;
        private List<string> users;

        public Server()
        {
            InitializeComponent();

            clientHandleMailSlot = DIS.Import.CreateMailslot("\\\\.\\mailslot\\ServerMailslot",
                                                                0,
                                                                DIS.Types.MAILSLOT_WAIT_FOREVER,
                                                                0);
            mailSlotName = $@"\\{Dns.GetHostName()}\mailslot\ServerMailslot";
            this.Text = $"     {mailSlotName}";

            _continue = true;
            users = new List<string>();

            hThread = new Thread(ReceiveMessage);
            hThread.Start();
        }

        // Получение сообщения от клиента
        private string GetMessage()
        {
            uint realBytesReaded = 0;

            byte[] buff = new byte[1024];
            DIS.Import.FlushFileBuffers(clientHandleMailSlot);
            DIS.Import.ReadFile(clientHandleMailSlot, buff, 1024, ref realBytesReaded, 0);
            string msg = Encoding.Unicode.GetString(buff);

            return msg;
        }

        // Рассылка сообщений пользователям чата
        private void SendUsersMessage(string msg, string name)
        {
            for (int i = 0; i < users.Count; i++)
            {
                uint BytesWritten = 0;

                if (!name.Equals(users[i]))
                {
                    byte[] buff = Encoding.Unicode.GetBytes(msg);
                    pUser = DIS.Import.CreateFile($@"\\.\mailslot\{users[i]}",
                                                    DIS.Types.EFileAccess.GenericWrite,
                                                    DIS.Types.EFileShare.Read,
                                                    0,
                                                    DIS.Types.ECreationDisposition.OpenExisting,
                                                    0,
                                                    0);
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
            int MailslotSize = 0;
            int lpNextSize = 0;
            int MessageCount = 0;
            string name = string.Empty;

            while (_continue)
            {
                DIS.Import.GetMailslotInfo(clientHandleMailSlot, MailslotSize, ref lpNextSize, ref MessageCount, 0);

                if (MessageCount > 0)
                {
                    for (int i = 0; i < MessageCount; i++)
                    {
                        msg = GetMessage();

                        Invoke((MethodInvoker)delegate
                        {
                            rtbMessages.Text += $@"{'\n'} >> {msg}";
                        });

                        name = Regex.Match(msg, @"(.*?) >>").Groups[1].Value;
                        if (!users.Contains(name)) users.Add(name);

                    }
                    
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

            if (clientHandleMailSlot != -1)
                DIS.Import.CloseHandle(clientHandleMailSlot);
        }
    }
}