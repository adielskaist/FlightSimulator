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
        TcpListener listener;
        StreamReader streamReader;

        public void connect(string ip, int port)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), port);
            listener = new TcpListener(ep);
            listener.Start();
            new Thread(() => 
                {
                    try
                    {
                        client = listener.AcceptTcpClient();
                        if (client.Connected)
                        {
                            stream = client.GetStream();
                            streamReader = new StreamReader(stream);
                            Console.WriteLine("Info port connected.");
                        }
                    } catch(SocketException e) { Console.WriteLine("disconnected"); }
                }).Start();
        }

        public string read()
        {
            string line = streamReader.ReadLine();
            return line;
        }

        public bool IsConnected()
        {
            if (client.Connected) { return true; }
            return false;
        }

        public void disconnect()
        {
            try
            {
                client.Close();
            } catch(NullReferenceException e) { Console.WriteLine("disconnected"); }
            listener.Stop();
        }
    }
}
