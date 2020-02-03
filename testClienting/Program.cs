using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace testClienting
{
    class Program
    {
        private static IPAddress ip = new IPAddress(new byte[] { 127, 0, 0, 1 });
        private static TcpListener server = new TcpListener(ip, 6000);
        private static Socket socket;
        private static List<EndPoint> clients = new List<EndPoint>();
        private static List<string> rooms = new List<string>();
        private static NetworkStream stream;
        private static AsyncCallback callback = new AsyncCallback(ReadData);        

        private static void ReadData(IAsyncResult result)
        {

        }

        static void Main(string[] args)
        {
            #region oldway
            while (true)
            {
                Console.WriteLine("Wating for a client to Connect");
                server.Start();
                socket = server.AcceptSocket();
                stream = new NetworkStream(socket);
                clients.Add(socket.RemoteEndPoint);
                for (int i = 0; i < clients.Count; i++)
                {
                    stream.Write(Encoding.Default.GetBytes(clients[i].ToString()), 0, clients[i].ToString().Length);
                }
                foreach (var c in clients)
                {
                    Console.WriteLine(c);
                }

                // this code should run in a seperated thread
                byte[] data = new byte[1024];                
                stream.BeginRead(data, 0, data.Length, callback, null);
                Console.WriteLine(Encoding.Default.GetString(data));
            }
            #endregion

        }
    }
}
