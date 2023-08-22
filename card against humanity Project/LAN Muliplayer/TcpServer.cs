using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace card_against_humanity_Project.LAN_Muliplayer
{
    internal class TcpServer
    { 
        private TcpListener _listener;
        public TcpServer() 
        {
            StartServer();
        }

        private void StartServer()
        {
            var port = 13000;
            var hostAddress = IPAddress.Parse("127.0.0.1");
            _listener = new TcpListener(hostAddress, port);
            _listener.Start();

            byte[] buffer = new byte[256];
            string recievedMessage;

            using TcpClient clinet = _listener.AcceptTcpClient();

            var tcpStream = clinet.GetStream();

            int readTotal;

            while((readTotal = tcpStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                string incomingMessage = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
            }
        }



    }
}
