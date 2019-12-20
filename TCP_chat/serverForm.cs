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

namespace chat_server
{
    public partial class formServer : Form
    {
        public formServer()
        {
            InitializeComponent();

            try
            {
                // получение перечня файлов в папке сервера
                files = Directory.GetFiles(Environment.CurrentDirectory);
                string delPattern = files[0].Remove(files[0].LastIndexOf('\\') + 1);
                for (int i = 0; i < files.Length; ++i)
                {
                    files[i] = (i + 1) + ". " + files[i].Replace(delPattern, "");
                }

                // создание конечной точки
                ipAddress = new IPEndPoint(Dns.GetHostByName(Dns.GetHostName()).AddressList[0], this.portNumber);
                // создание сокета
                this.listenSocket = new Socket(AddressFamily.Ipx, SocketType.Stream, ProtocolType.S);
                // привязка сокета к конечной точке
                listenSocket.Bind(ipAddress);
                // создание потока для прослушивания
                connectionThread = new Thread(new ThreadStart(this.startListening));
                connectionThread.Name = "connection_thread";
                isConnected = false;
                Lock = new object();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private int portNumber = 8005;
        IPEndPoint ipAddress;
        Socket listenSocket;
        Socket connectSocket;
        StringBuilder builder;
        private Thread connectionThread;
        private object Lock;
        private bool isConnected;
        string[] files;


        private void startListening()
        {
            // прослушивание подключений
            listenSocket.Listen(1);
            MessageBox.Show("Server is waiting for connections...");
            // установление подключения
            connectSocket = listenSocket.Accept();
            MessageBox.Show("Connection is successful"); 
            this.isConnected = true;

            while (isConnected)
            {
                try
                {
                    builder = new StringBuilder();
                    int bytes = 0; // количество полученных байтов
                    byte[] data = new byte[256]; // буфер для получаемых данных

                    lock (Lock)
                    {
                        do
                        {
                            // получаем сообщение
                            bytes = connectSocket.Receive(data);
                            builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                        }
                        while (connectSocket.Available > 0);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                string message = builder.ToString();

                if (message == "$ getServerFiles")
                {
                    // если от клиента пришел запрос на список файлов сервера
                    // отпрвка перечня файлов
                    SendData(GetServerFiles());
                }
                else if (message.StartsWith("$ getFileById "))
                {
                    // если от клиента пришел запрос на файл
                    // считывание ИД файла
                    message = message.Replace("$ getFileById ", "");
                    // получаем имя файла
                    string fileName = files[Convert.ToInt32(message) - 1].Remove(0, files[Convert.ToInt32(message) - 1].IndexOf('.') + 2);
                    // считываем файл
                    StreamReader fs = new StreamReader(Environment.CurrentDirectory + "\\" + fileName);
                    string data = fs.ReadToEnd();
                    fs.Dispose();
                    // отправляем файл с пометками о том что передаваемое сообщение файл
                    SendData("%FILE%" + "%" + fileName + "%" + data);
                }
                else
                {
                    // иначе просто выводим полученый текст сообщения
                    SetLabelText(message);
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
            // запускаем поток слушателя
            this.connectionThread.Start();
        }

        private void CloseConnection_Click(object sender, EventArgs e)
        {
            try
            {
                // закрываем сокет и разрываем соединение
                connectSocket.Shutdown(SocketShutdown.Both);
                connectSocket.Close();
                isConnected = false;
                connectionThread.Abort();
                listenSocket.Disconnect(false);
            }
            catch { }
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            if (!isConnected) return;
            // отправляем сообщение
            SendData(this.TB_Message.Text);
        }

        private void SendData(string data)
        {
            try
            {
                // отправка сообщения
                connectSocket.Send(Encoding.Unicode.GetBytes(data));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void formServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            // выход из приложения
            Application.Exit();
        }

        private void apiData_Click(object sender, EventArgs e)
        {
            // Вывод данных о точке входа в АПИ и данных о текущем IP адресе и порте
            MessageBox.Show(
                "API Address: 0x" + APIAddress.GetAPIAddress()
                    + "\nIP Address:    " + ipAddress.Address
                    + "\nSocket :          " + ipAddress.Port,
                "Server"
            );
        }

        private void ServerFiles_Click(object sender, EventArgs e)
        {
            // дополнение текстового поля с сообщениями перечнем файлов в папке сервера
            textMessage.AppendText(GetServerFiles());
        }

        private string GetServerFiles()
        {
            // формирование перечня файлов в папке сервера
            string serverFiles = "Server files:" + Environment.NewLine;
            foreach (string item in files)
            {
                serverFiles += " " + item + Environment.NewLine;
            }
            return serverFiles;
        }
        #endregion
        
    }
}
