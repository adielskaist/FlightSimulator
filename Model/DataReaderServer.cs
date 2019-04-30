using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using FlightSimulator.Model;

namespace FlightSimulator.Model
{
    class DataReaderServer : ITelnetServer
    {
        private static ITelnetServer m_Instance = null;
        public static ITelnetServer Instance
        {
            get
            {
                if(m_Instance == null)
                {
                    m_Instance = new DataReaderServer();
                }
                return m_Instance;
            }
        }

        TcpClient client;
        NetworkStream stream;
        BinaryReader reader;
        TcpListener listener;
        StreamReader streamReader;

        public void connect(string ip, int port)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), port);
            listener = new TcpListener(ep);
            listener.Start();
            new Thread(() => 
                {
                    client = listener.AcceptTcpClient();
                    if (client.Connected)
                    {
                        stream = client.GetStream();
                        reader = new BinaryReader(stream);
                        streamReader = new StreamReader(stream);
                        Console.WriteLine("Info port connected.");
                    }
                }).Start();
        }

        public string read()
        {
            string line = streamReader.ReadLine();
            return line;
        }

        public void disconnect()
        {
            client.Close();
            listener.Stop();
        }
    }
}
