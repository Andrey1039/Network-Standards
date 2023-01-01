using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Sockets
{
    public partial class Server : Form
    {
        private Socket clientSock;
        private TcpListener listener;
        private List<Thread> threads;
        private bool _continue = true;

        private List<string> users;
        private List<int> port;
        List<TcpClient> persons;
        Thread hThread;
        IPAddress ip;
        int _port;

        public Server()
        {
            InitializeComponent();

            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            ip = hostEntry.AddressList[0];
            _port = 1010;

            foreach (IPAddress address in hostEntry.AddressList)
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ip = address;
                    break;
                }

            this.Text = $"     {ip}:{_port}";

            threads = new List<Thread>();
            users = new List<string>();
            port = new List<int>();
            persons = new List<TcpClient>();

            listener = new TcpListener(ip, _port);
            listener.Start();

            threads.Clear();
            threads.Add(new Thread(ReceiveMessage));
            threads[threads.Count - 1].Start();

            hThread = new Thread(WaitForConnection);
            hThread.Start();
        }

        // Ожидание подключения клиентов
        private void WaitForConnection()
        {
            while (true)
            {
                int recv;
                byte[] data = new byte[1024];

                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 1011);
                Socket srvSock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                srvSock.Bind(ipep);

                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
                EndPoint remote = (EndPoint)(sender);

                recv = srvSock.ReceiveFrom(data, ref remote);
                data = Encoding.UTF8.GetBytes(ip.ToString());
                srvSock.SendTo(data, data.Length, SocketFlags.None, remote);

                srvSock.Close();
            }
        }

        // Получение сообщений от клиентов
        private void ReceiveMessage()
        {
            while (_continue)
            {
                clientSock = listener.AcceptSocket();
                threads.Add(new Thread(ReadMessages));
                threads[threads.Count - 1].Start(clientSock);
            }
        }
      
        // Рассылка сообщений пользователям чата
        private void SendUsersMessages(string msg, string message)
        {
            string clientPort = Regex.Match(msg, ":(.*?) >>").Groups[1].Value;
            string clientIp = Regex.Match(msg, "(.*?):").Groups[1].Value;

            if (!users.Contains(clientIp) || !port.Contains(int.Parse(clientPort)))
            {
                users.Add(clientIp);
                port.Add(int.Parse(clientPort));
                persons.Add(new TcpClient());
                persons[persons.Count - 1].Connect(IPAddress.Parse(users[persons.Count - 1]), port[persons.Count - 1]);
            }

            for (int i = 0; i < users.Count; i++)
            {
                if (!Regex.Match(msg, "(.*?) >>").Groups[1].Value.Equals($"{users[i]}:{port[i]}"))
                {
                    byte[] buff = Encoding.Unicode.GetBytes(message);
                    Stream stm = persons[i].GetStream();
                    stm.Write(buff, 0, buff.Length);
                }
            }
        }

        // Чтение сообщений от клиентов
        private void ReadMessages(object ClientSock)
        {
            while (_continue)
            {
                byte[] buff = new byte[1024];
                ((Socket)ClientSock).Receive(buff);
                string msg = System.Text.Encoding.Unicode.GetString(buff);

                string message = msg.Substring(msg.IndexOf('>'), msg.IndexOf('\0'));

                Invoke((MethodInvoker)delegate
                {
                    MessagesTB.Text += $"{'\n'}{message}";
                });

                SendUsersMessages(msg, message);

                Thread.Sleep(500);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _continue = false;

            for (int i = 0; i < users.Count; i++)
                persons[i].Close();

            foreach (Thread t in threads)
            {
                t.Abort();
                t.Join(500);
            }

            if (clientSock != null)
                clientSock.Close();

            if (listener != null)
                listener.Stop();

            Process id = Process.GetCurrentProcess();
            id.Kill();
        }
    }
}