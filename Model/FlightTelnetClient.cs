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
        void ITelnetClient.connect(string ip, int port)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), port);
            client = new TcpClient();
            new Thread(() =>
            {
                while(!client.Connected){
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
            }).Start();
        }

        void ITelnetClient.write(string command)
        {
            byte[] msg = ASCIIEncoding.ASCII.GetBytes(command);
            try { stream.Write(msg, 0, msg.Length); }
            catch (NullReferenceException e) { }
        }
        

        void ITelnetClient.disconnect()
        {
            client.Close();
        }
    }
}
