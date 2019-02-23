﻿namespace HTTP_Server
{
    using HTTP_Server.Contracts;
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
     
    public class HttpServer : IHttpServer
    {
        private bool isWorking;

        private readonly TcpListener tcpListener;

        public HttpServer()
        {
            isWorking = true;
            this.tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 80);
        }

        public void Start()
        {
            Console.WriteLine("Started!");
            this.isWorking = true;
            this.tcpListener.Start();
            while (this.isWorking)
            {
                var client = this.tcpListener.AcceptTcpClient();
                var buffer = new byte[10240];
                var stream = client.GetStream();
                var readLength = stream.Read(buffer, 0, buffer.Length);
                var requestText = Encoding.UTF8.GetString(buffer, 0, readLength);
                Console.WriteLine(new string('-', 60));
                Console.WriteLine(requestText);
                var responseText = File.ReadAllText("index.html");
                var responseBytes = Encoding.UTF8.GetBytes("HTTP/1.0 200 OK" +
                                                            Environment.NewLine  + 
                                                            "Content-Length: " + responseText.Length  +
                                                            Environment.NewLine  +
                                                            Environment.NewLine + responseText);
                stream.Write(responseBytes);
            }

        }

        public void Stop()
        {
            isWorking = false;
        }
    }
}