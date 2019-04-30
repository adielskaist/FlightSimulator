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
        #region Singleton
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
        #endregion

        TcpClient client;
        NetworkStream stream;
        TcpListener listener;
        StreamReader streamReader;
        
        /// <summary>
        /// connecting the client to the simulator client.
        /// </summary>
        /// <param name="ip">the IP</param>
        /// <param name="port">the socket number</param>
        public void Connect(string ip, int port)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), port);
            listener = new TcpListener(ep);
            listener.Start();

            //trying to connect to the client.
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
                    } catch(SocketException e) { Console.WriteLine("disconnected"); } //in case disconnect button is pressed
                }).Start();
        }
        /// <summary>
        /// reading a string from the flight simulator
        /// </summary>
        /// <returns>a string</returns>
        public string read()
        {
            string line = streamReader.ReadLine();
            return line;
        }

        /// <summary>
        /// in case disconnect button is pressed
        /// </summary>
        public void Disconnect()
        {
            try
            {
                client.Close();
            } catch(NullReferenceException e) { Console.WriteLine("disconnected"); }
            listener.Stop();
        }
    }
}
