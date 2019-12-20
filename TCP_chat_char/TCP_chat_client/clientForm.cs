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


namespace TCP_chat_client
{
    public partial class formClient : Form
    {
        public formClient()
        {
            InitializeComponent();
        }


        private int portNumber = 8005;
        private IPEndPoint ipAddress;
        private Socket socket;
        private bool trigger = false;


        private void TB_TextMessage_TextChanged(object sender, EventArgs e)
        {
            if (!trigger)
            {
                TB_Log.Text += "Connected to server\r\n";
                trigger = true;
            }

            try
            {
                ipAddress = new IPEndPoint(Dns.GetHostByName(Dns.GetHostName()).AddressList[0], portNumber);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // подключаемся к удаленному хосту
                socket.Connect(ipAddress);

                string message = TB_TextMessage.Text;
                byte[] data = Encoding.Unicode.GetBytes(message);
                socket.Send(data);

                // получаем ответ
                data = new byte[64]; // буфер для ответа
                StringBuilder builder = new StringBuilder();
                int bytes = 0; // количество полученных байт

                do
                {
                    bytes = socket.Receive(data, data.Length, 0);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (socket.Available > 0);
                TB_Log.Text += "Server reply: " + builder.ToString() + "\r\n";

            }
            catch (Exception ex)
            {
                TB_Log.Text += ex.Message + "\r\n";
            }
        }

        private void formClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            catch (Exception ex)
            {
                TB_Log.Text += ex.Message + "\r\n";
            }
        }

    }
}
