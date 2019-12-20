using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TCP_chat_client
{
    public partial class formClient : Form
    {
        // port of connection server
        private int port = 8005;
        // true if connection exists
        private bool isConnection;
        // ip address of connection server
        private IPEndPoint ipAddress;
        private Socket connectSocket;
        private Thread connectionThread;
        private object lockSocket;

        public formClient()
        {
            InitializeComponent();
            try
            {
                ipAddress = new IPEndPoint(Dns.GetHostByName(Dns.GetHostName()).AddressList[0], port);
                connectSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                lockSocket = new object();
                connectionThread = new Thread(new ThreadStart(startListening));
                connectionThread.Name = "client_listening_thread";
            }
            catch (NullReferenceException ex)
            {
                toolStatusInfo.Text = ex.Message;
                return;
            }
        }

        private void startListening()
        {
            string incomeMessage;
            try
            {
                while (isConnection)
                {
                    incomeMessage = String.Empty;
                    // получаем сообщение
                    int bytes = 0; // количество полученных байтов
                    byte[] data = new byte[256]; // буфер для получаемых данных
                    lock (lockSocket)
                    {
                        do
                        {
                            bytes = connectSocket.Receive(data);
                            incomeMessage += Encoding.Unicode.GetString(data, 0, bytes);
                        }
                        while (connectSocket.Available > 0);
                    }
                    //textAcceptMessage.Text += DateTime.Now.ToShortTimeString() + ": " + incomeMessage;
                    MessageBox.Show("From server : " + DateTime.Now.ToShortTimeString() + ": " + incomeMessage);
                }
            }
            catch (SocketException ex)
            {
                textRecieve.Text = ex.Message;
                return;
            }
        }

        #region Button_event_handlers

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (textRecieve.Text == "") throw new ArgumentException("Type some text!");
                string message = textSend.Text;
                byte[] data = Encoding.Unicode.GetBytes(message);
                connectSocket.Send(data);

            }
            catch (ArgumentException ex)
            {
                toolStatusInfo.Text = ex.Message;
                return;
            }
            catch (SocketException ex)
            {
                toolStatusInfo.Text = ex.Message;
                return;
            }

        }

        private void buttonCloseConnection_Click(object sender, EventArgs e)
        {
            // закрываем сокет
            connectSocket.Shutdown(SocketShutdown.Both);
            connectSocket.Close();
            isConnection = false;
        }

        private void buttonCreateConnection_Click(object sender, EventArgs e)
        {
            try
            {
                // try to connect to remote port
                // if socket is disconnected
                if (!connectSocket.Connected)
                {
                    connectSocket.Connect(ipAddress);
                }
                else throw new TimeoutException("Socket already exists. First close previous connection, then try again.");
            }
            catch (SocketException ex)
            {
                toolStatusInfo.Text = ex.Message;
            }
            catch (TimeoutException ex)
            {
                toolStatusInfo.Text = ex.Message;
            }
            this.isConnection = true;

            // start listen for income
            this.connectionThread.Start();
        }

        #endregion
    }
}
