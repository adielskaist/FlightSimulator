using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlightSimulator.Model
{
    class FlightTelnetClient : ITelnetClient
    {
        TcpClient client;
        NetworkStream stream;
        #region Singleton
        private static ITelnetClient m_Instance = null;

        public static ITelnetClient Instance
        {
            get
            {
                if(m_Instance == null)
                {
                    m_Instance = new FlightTelnetClient();
                }
                return m_Instance;
            }
        }
        #endregion

        /// <summary>
        /// connecting to the simulator server
        /// </summary>
        /// <param name="ip">the IP</param>
        /// <param name="port">the socket number</param>
        void ITelnetClient.connect(string ip, int port)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), port);
            client = new TcpClient();
            new Thread(() =>
            {
                try
                {
                    while(!client.Connected){   // trying to connect until success
                        try
                        {
                            client.Connect(ep);
                        } catch(SocketException e) { }
                    }
                    if (client.Connected)
                    {
                        stream = client.GetStream();
                        Console.WriteLine("Command Port connected.");
                    }
                }
                catch (NullReferenceException e) { }
            }).Start();
        }

        /// <summary>
        /// sending commands to the simulator
        /// </summary>
        /// <param name="command">the command massage</param>
        void ITelnetClient.write(string command)
        {
            byte[] msg = ASCIIEncoding.ASCII.GetBytes(command);
            try { stream.Write(msg, 0, msg.Length); }
            catch (NullReferenceException e) { }
        }

        
        /// <summary>
        /// disconnecting
        /// </summary>
        void ITelnetClient.Disconnect()
        {
            client.Close();
        }
    }
}
