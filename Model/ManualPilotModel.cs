using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.Model.Interface;

namespace FlightSimulator.Model
{
    class ManualPilotModel
    {
        private static ManualPilotModel m_Instance = null;

        public static ManualPilotModel Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new ManualPilotModel();
                }
            return m_Instance;
            }
        }

        ITelnetClient client = FlightTelnetClient.Instance;
        
        public double rudder
        {
            set { client.write("set /controls/flight/rudder " + value.ToString() + "\r\n"); }
        }

        public double throttel
        {
            set { client.write("set /controls/engines/current-engine/throttle " + value.ToString() + "\r\n"); }
        }

        public double aileron
        {
            set { client.write("set /controls/flight/aileron " + value.ToString() + "\r\n"); }
        }
        
        public double elevator
        {
            set { client.write("set /controls/flight/elevator " + value.ToString() + "\r\n"); }
        }
    }
}
