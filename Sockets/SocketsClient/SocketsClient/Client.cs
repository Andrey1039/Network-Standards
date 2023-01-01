using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Sockets
{
    public partial class Client : Form
    {
        int port;
        private IPAddress ip;
        private TcpClient client;
        private Socket clientSock;
        private TcpListener listener;
        private List<Thread> threads;
        private bool _continue = true;

        public Client()
        {
            InitializeComponent();

            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            ip = hostEntry.AddressList[0];

            foreach (IPAddress address in hostEntry.AddressList)
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ip = address;
                    break;
                }

            this.Text = $"     {ip}";

            Random rand = new Random();
            port = rand.Next(0,10000);

            listener = new TcpListener(ip, port);
            listener.Start();

            client = new TcpClient();
            threads = new List<Thread>();

            threads.Clear();
            threads.Add(new Thread(ReceiveMessage));
            threads[threads.Count - 1].Start();
        }

        // Широковещательный запрос
        private string UdpConnect()
        {
            string stringData;

            UdpClient server = new UdpClient("127.0.0.1", 1011);

            IPEndPoint sender1 = new IPEndPoint(IPAddress.Any, 0);

            byte[] data = Encoding.UTF8.GetBytes("Hello");
            server.Send(data, data.Length);

            data = server.Receive(ref sender1);
            stringData = Encoding.UTF8.GetString(data, 0, data.Length);

            return stringData;          
        }

        // Подключение к серверу по TCP
        private void TcpConnect(string ip)
        {
            IPAddress aipi = IPAddress.Parse(ip);
            client.Connect(aipi, 1010);

            IpTB.Text = $"{ip}:1010";
        }

        // Отправка сообщения на сервер
        private void SendMessage()
        {
            string msg = $"{ip}:{port} >> {LoginTB.Text} >> {MessageTB.Text}";
            byte[] buff = Encoding.Unicode.GetBytes(msg);

            MessagesTB.Text += $"Ваше сообщение: {MessageTB.Text}{Environment.NewLine}";

            Stream stm = client.GetStream();
            stm.Write(buff, 0, buff.Length);
        }

        // Получение сообщений от сервера
        private void ReceiveMessage()
        {
            while (_continue)
            {
                clientSock = listener.AcceptSocket();
                threads.Add(new Thread(ReadMessages));
                threads[threads.Count - 1].Start(clientSock);
            }
        }

        // Чтение сообщений от сервера
        private void ReadMessages(object ClientSock)
        {
            while (_continue)
            {
                byte[] buff = new byte[1024];
                ((Socket)ClientSock).Receive(buff);
                string msg = System.Text.Encoding.Unicode.GetString(buff);

                Invoke((MethodInvoker)delegate
                {
                    MessagesTB.Text += msg;
                    MessagesTB.Text += Environment.NewLine;
                });

                Thread.Sleep(500);
            }
        }

        private void SendMessBtn_Click(object sender, EventArgs e)
        {
            if (!IpTB.Text.Equals(string.Empty) &&
                !LoginTB.Text.Equals(string.Empty) &&
                !MessageTB.Text.Equals(string.Empty))

                SendMessage();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = UdpConnect();
                TcpConnect(ip);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при подключении к серверу");
                return;
            }

            ConnectBtn.Enabled = false;
            SendMessBtn.Enabled = true;
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();

            Process id = Process.GetCurrentProcess();
            id.Kill();
        }
    }
}