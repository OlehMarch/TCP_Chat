﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TCP_chat_server_console
{
    class Program
    {
        static int port = 8005;

        static void Main(string[] args)
        {
            IPEndPoint ipPoint = new IPEndPoint(Dns.GetHostByName(Dns.GetHostName()).AddressList[0], port);
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listenSocket.Bind(ipPoint);
                listenSocket.Listen(10);

                Console.WriteLine("Server is waiting for connections...");

                while (true)
                {
                    Socket handler = listenSocket.Accept();

                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    byte[] data = new byte[256];

                    do
                    {
                        bytes = handler.Receive(data);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (handler.Available > 0);

                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine(DateTime.Now.ToShortTimeString() + ": " + builder.ToString());

                    string message = "Your message was delivered";
                    data = Encoding.Unicode.GetBytes(message);
                    handler.Send(data);

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }

}
