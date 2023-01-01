using System;
using System.Net;
using System.Threading;
using System.Messaging;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MSMQ
{
    public partial class Server : Form
    {
        private MessageQueue q = null;
        private Thread t = null;
        private bool _continue = true;

        private List<MessageQueue> q1 = new List<MessageQueue>();
        private List<string> users = new List<string>();

        public Server()
        {
            InitializeComponent();
            string path = $@"{Dns.GetHostName()}\private$\ServerQueue";

            if (MessageQueue.Exists(path))
                q = new MessageQueue(path);
            else
                q = MessageQueue.Create(path);

            q.Formatter = new XmlMessageFormatter(new Type[] { typeof(String) });

            this.Text = $"     {q.Path}";

            Thread t = new Thread(ReceiveMessage);
            t.Start();
        }

        // Рассылка сообщений пользователям чата
        private void SendUsersMessages(System.Messaging.Message msg)
        {
            string text = Regex.Match((string)msg.Body, "(.*?) >>").Groups[1].Value;

            if (MessageQueue.Exists($@"{msg.Label}\private$\{text}") &&
                !users.Contains(text))
            {
                q1.Add(new MessageQueue($@"{msg.Label}\private$\{text}"));
                users.Add(text);
            }

            for (int i = 0; i < q1.Count; i++)
            {
                q1[i].Send(msg.Body, Dns.GetHostName());
            }
        }

        // Получение сообщений от клиентов
        private void ReceiveMessage()
        {
            if (q == null)
                return;

            System.Messaging.Message msg = null;

            while (_continue)
            {
                if (q.Peek() != null)
                    msg = q.Receive(TimeSpan.FromSeconds(10.0));

                if (msg != null)
                {
                    rtbMessages.Invoke((MethodInvoker)delegate
                    {
                        rtbMessages.Text += $">> {msg.Label} >> {msg.Body}";
                        rtbMessages.Text += Environment.NewLine;
                    });

                    SendUsersMessages(msg);
                }

                Thread.Sleep(500);
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            _continue = false;

            if (t != null)
            {
                t.Abort();
            }

            if (q != null)
            {
                MessageQueue.Delete(q.Path);
            }
        }
    }
}