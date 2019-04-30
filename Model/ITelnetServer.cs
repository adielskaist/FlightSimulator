using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.Model
{
    interface ITelnetServer
    {
        void Connect(string ip, int port);
        string read();
        void Disconnect();
    }
}
