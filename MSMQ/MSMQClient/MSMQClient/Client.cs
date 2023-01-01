using System;
using System.Net;
using System.Messaging;
using System.Threading;
using System.Windows.Forms;

namespace MSMQ
{
    public partial class Client : Form
    {
        private MessageQueue q;
        private MessageQueue q1;
        private Thread hThread;
        private bool _continue;

        public Client()
        {
            InitializeComponent();

            q = null;
            q1 = null;
            hThread = null;
            _continue = true;
        }

        // Подключение к очереди
        private void Connect()
        {
            if (MessageQueue.Exists(QueuePathTB.Text))
            {
                q = new MessageQueue(QueuePathTB.Text);
                SendMessageBtn.Enabled = true;
                ConnectBtn.Enabled = false;

                string path = $@"{Dns.GetHostName()}\private$\{LoginTB.Text}";

                if (MessageQueue.Exists(path))
                    q1 = new MessageQueue(path);
                else
                    q1 = MessageQueue.Create(path);

                q1.Formatter = new XmlMessageFormatter(new Type[] { typeof(String) });

                this.Text = $"     {q1.Path}";

                Thread t = new Thread(ReceiveMessage);
                t.Start();
            }
            else
                MessageBox.Show("Указан неверный путь к очереди, либо очередь не существует");
        }

        // Получение сообщений из очереди
        private void ReceiveMessage()
        {
            if (q1 == null)
                return;

            System.Messaging.Message msg = null;

            while (_continue)
            {
                if (q1.Peek() != null)
                    msg = q1.Receive(TimeSpan.FromSeconds(10.0));

                if (msg != null)
                    Invoke((MethodInvoker)delegate
                    {
                        MessagesTB.Text += $">> {msg.Label} >> {msg.Body}";
                    });

                Thread.Sleep(500);
            }
        }

        // Отправка сообщений на сервер
        private void SendMessage()
        {
            q.Send($"{LoginTB.Text} >> {MessageTB.Text}", Dns.GetHostName());
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
            if (!QueuePathTB.Text.Equals(string.Empty) &&
                !LoginTB.Text.Equals(string.Empty) &&
                !MessageTB.Text.Equals(string.Empty))

                SendMessage();
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            _continue = false;

            if (hThread != null)
            {
                hThread.Abort();
            }

            if (q1 != null)
            {
                MessageQueue.Delete(q1.Path);
            }
        }
    }
}