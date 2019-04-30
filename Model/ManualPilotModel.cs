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
        #region Singleton
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
        #endregion

        ITelnetClient client = FlightTelnetClient.Instance;
        
        public double Rudder
        {
            set { client.write("set /controls/flight/rudder " + value.ToString() + "\r\n"); }   //sending rudder commands
        }

        public double Throttel
        {
            set { client.write("set /controls/engines/current-engine/throttle " + value.ToString() + "\r\n"); }     //sending throttle commands
        }

        public double Aileron
        {
            set { client.write("set /controls/flight/aileron " + value.ToString() + "\r\n"); }      //sending aileron commands
        }
        
        public double Elevator
        {
            set { client.write("set /controls/flight/elevator " + value.ToString() + "\r\n"); }     //sending elevator commands
        }
    }
}
