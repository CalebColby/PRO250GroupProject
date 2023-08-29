using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace card_against_humanity_Project.LAN_Muliplayer
{
    internal class TcpServer
    { 
        private TcpListener server = null;
        private List<TcpClient> clients = new List<TcpClient>();
        private CancellationTokenSource cancellationService = new CancellationTokenSource();
        public TcpServer() 
        {
            _ = StartServer();
        }

        ~TcpServer()
        {
            if(server != null) server.Stop();
        }

        private void StartServer()
        {
            try
            {
                var port = 1998;
                var hostAddress = IPAddress.Parse("127.0.0.1");

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(hostAddress, port);

                // Start listening for client requests.
                server.Start();

                _ = AcceptClients();
                _ = HandleTcpClinets();
            }
            catch (SocketException e)
            {
                server?.Stop();
                Console.WriteLine("SocketException: {0}", e);
            }
        }

        private async Task AcceptClients()
        {
            while(!cancellationService.IsCancellationRequested)
            {
                var client = server.AcceptTcpClient();

                clients.Add(client);
            }
        }
        private async Task HandleTcpClinets()
        {
            while (!cancellationService.IsCancellationRequested)
            {
                if (clients.Count == 0) continue;

                foreach (var client in clients)
                {

                }
            }
        }
    }
}
