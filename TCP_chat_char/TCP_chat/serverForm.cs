using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

namespace TCP_chat_server
{
    public partial class formServer : Form
    {
        public formServer()
        {
            InitializeComponent();
        }

        
        protected int portNumber = 8005;
        private IPEndPoint ipAddress;
        private Socket listenSocket;
        private Socket handler;
        private object lockSocket;


        private void SocketListener()
        {
            try
            {
                // create ip end address to start socket
                ipAddress = new IPEndPoint(Dns.GetHostByName(Dns.GetHostName()).AddressList[0], portNumber++);
                // create main listen socket
                listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // связываем сокет с локальной точкой, по которой будем принимать данные
                listenSocket.Bind((EndPoint)ipAddress);

                // начинаем прослушивание
                listenSocket.Listen(10);

                TB_Log.Text += "Server is waiting for connections...\r\n";

                handler = listenSocket.Accept();

                // получаем сообщение
                StringBuilder builder = new StringBuilder();
                int bytes = 0; // количество полученных байтов
                byte[] data = new byte[64]; // буфер для получаемых данных

                lock (lockSocket)
                {
                    do
                    {
                        bytes = handler.Receive(data);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (handler.Available > 0);
                
                // отправляем ответ
                string message = "Your message was delivered";
                data = Encoding.Unicode.GetBytes(message);
                handler.Send(data);
                }

                TB_TextMessage.Text += builder.ToString();
            }
            catch(Exception ex)
            {
                TB_Log.Text += ex.Message + "\r\n";
            }
        }

        private void TB_TextMessage_TextChanged(object sender, EventArgs e)
        {
            SocketListener();
        }

        private void formServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch (Exception ex)
            {
                TB_Log.Text += ex.Message + "\r\n";
            }
        }

        private void formServer_Load(object sender, EventArgs e)
        {
            try
            {
                SocketListener();
                portNumber++;
            }
            catch (Exception ex)
            {
                TB_Log.Text += ex.Message + "\r\n";
            }
        }
    }
}
