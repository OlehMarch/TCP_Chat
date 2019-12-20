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
using System.IO;

namespace chat_client
{
    public partial class formClient : Form
    {
        public formClient()
        {
            InitializeComponent();

            // создание конечной точки
            ipPoint = new IPEndPoint(Dns.GetHostByName(Dns.GetHostName()).AddressList[0], port);
            // создание сокета
            socket = new Socket(AddressFamily.Ipx, SocketType.Stream, ProtocolType.Spx);
            Lock = new object();
            // создание потока для прослушивания
            connectionThread = new Thread(new ThreadStart(startListening));
            connectionThread.Name = "client_listening_thread";
        }

        // адрес и порт сервера, к которому будем подключаться
        private int port = 8005; // порт сервера
        private bool isConnected;
        private IPEndPoint ipPoint;
        private Socket socket;
        StringBuilder builder;
        private Thread connectionThread;
        private object Lock;


        private void startListening()
        {
            while (isConnected)
            {
                builder = new StringBuilder();
                int bytes = 0; // количество полученных байтов
                byte[] data = new byte[256]; // буфер для получаемых данных

                lock (Lock)
                {
                    do
                    {
                        // получаем сообщение
                        bytes = socket.Receive(data);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (socket.Available > 0);
                }

                string message = builder.ToString();
                if (message.StartsWith("%FILE%"))
                {
                    // если в сообщении имеется ИД того что это файл
                    // убираем этот ИД
                    message = message.Replace("%FILE%", "");
                    // считываем имя файла
                    string fileName = message.Remove(message.IndexOf('%', 1)).Replace("%", "");
                    // удаляем из сообщения имя файла
                    message = message.Replace("%" + fileName + "%", "");
                    // создаем файл
                    StreamWriter fs = new StreamWriter(Environment.CurrentDirectory + "\\" + fileName);
                    fs.Write(message);
                    fs.Dispose();
                    SetLabelText("File received!");
                }
                else
                {
                    // иначе просто выводим полученое сообщение
                    SetLabelText(builder.ToString());
                }
            }
        }

        private void SetLabelText(string txt)
        {
            // добавление к сообщению времени его "прибытия"
            if (textMessage.InvokeRequired)
                textMessage.Invoke(new MethodInvoker(() => SetLabelText(txt)));
            else
                textMessage.Text += DateTime.Now.ToShortTimeString() + ": " + txt + "\r\n";
        }

        #region Actions
        private void buttonCreateConnection_Click(object sender, EventArgs e)
        {
            try
            {
                // установка коннекта по конечной точке
                socket.Connect(ipPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.isConnected = true;

            // start listen for income
            this.connectionThread.Start();

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (!isConnected) return;

            try
            {
                // отправляем сообщение
                byte[] data = Encoding.Unicode.GetBytes(this.TB_Message.Text);
                socket.Send(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseConnection_Click(object sender, EventArgs e)
        {
            try
            {
                // закрываем сокет
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                connectionThread.Abort();
            }
            catch { }
        }

        private void formClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            // выход из приложения
            Application.Exit();
        }

        private void apiData_Click(object sender, EventArgs e)
        {
            // Вывод данных о точке входа в АПИ и данных о текущем IP адресе и порте
            MessageBox.Show(
                "API Address: 0x" + APIAddress.GetAPIAddress()
                    + "\nIP Address:    " + ipPoint.Address
                    + "\nSocket :          " + ipPoint.Port,
                "Client"
            );
        }

        private void ServerFiles_Click(object sender, EventArgs e)
        {
            if (!isConnected) return;

            try
            {
                // отправка серверу запроса на получние перечня файлов
                byte[] data = Encoding.Unicode.GetBytes("$ getServerFiles");
                socket.Send(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FileGetter_Click(object sender, EventArgs e)
        {
            if (!isConnected) return;

            try
            {
                // отправка серверу запроса на получние файла по его ИД
                byte[] data = Encoding.Unicode.GetBytes("$ getFileById " + this.TB_Message.Text);
                socket.Send(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
