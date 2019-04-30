using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.Model
{
    interface ITelnetServer
    {
        void connect(string ip, int port);
        string read();
        void disconnect();
    }
}
