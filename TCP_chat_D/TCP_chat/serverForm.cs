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

namespace TCP_chat_server
{
    public partial class formServer : Form
    {
        private int portNumber = 8005;
        private bool isConnection;
        private IPEndPoint ipAddress;
        private Socket listenSocket;
        private Socket connectSocket;
        private Thread connectionThread;
        private Object lockSocket;

        public formServer()
        {
            InitializeComponent();

            try
            {
                // create ip end address to start socket
                ipAddress = new IPEndPoint(Dns.GetHostByName(Dns.GetHostName()).AddressList[0], this.portNumber);
                // create main listen socket
                this.listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // связываем сокет с локальной точкой, по которой будем принимать данные
                listenSocket.Bind(ipAddress);
                // bind thread with connect method
                connectionThread = new Thread(new ThreadStart(this.tryConnect));
                connectionThread.Name = "connection_thread";
                isConnection = false;
                lockSocket = new object();
            }
            catch(NullReferenceException)
            {
                //error
                return;
            }
        }

        private void tryConnect()
        {
            // some code for connection server with clients

            // начинаем прослушивание
            listenSocket.Listen(1);
            toolStatus.Text = "Server is waiting for connections...";
            // accept connection with client
            connectSocket = listenSocket.Accept();
            // connection has accepted
            toolStatus.Text = "Connection is successful.";
            //this.buttonSend.Enabled = true;
            this.isConnection = true;
            this.startListening();
        }

        private void startListening()
        {
            string incomeMessage;
            while (isConnection)
            {
                try
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
                }
                catch (SocketException ex)
                {
                    toolStatus.Text = ex.Message;
                    return;
                }
                //textAcceptMessage.Text += DateTime.Now.ToShortTimeString() + ": " + incomeMessage;
                MessageBox.Show("From client : " + DateTime.Now.ToShortTimeString() + ": " + incomeMessage);
            }
        }

        #region Button_event_handlers

        private void buttonSend_Click(object sender, EventArgs e)
        {
            // connection was broken
            if (!isConnection) return;

            byte[] data;
            try
            {
                if (textSendMessage.Text == "") throw new NotImplementedException();
            }
            catch (NotImplementedException)
            {
                toolStatus.Text = "Put some text to message box!";
                return;
            }
            data = Encoding.Unicode.GetBytes(this.textSendMessage.Text);
            try
            {
                // try to send data
                connectSocket.Send(data);
            }
            catch (SocketException ex)
            {
                textAcceptMessage.Text += ex.Message;
                return;
            }
        }

        private void buttonCreateConnection_Click(object sender, EventArgs e)
        {
            // start listening for connections
            this.connectionThread.Start();
        }

        private void buttonBreakConnection_Click(object sender, EventArgs e)
        {
            try
            {
                connectSocket.Shutdown(SocketShutdown.Both);
                connectSocket.Close();
                listenSocket.Disconnect(false);
                isConnection = false;
            }
            catch (NullReferenceException ex)
            {
                // there is no connection yet!
                toolStatus.Text = ex.Message;
                return;
            }
        }

        #endregion
    }
}
