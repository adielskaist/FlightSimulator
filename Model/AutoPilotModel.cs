using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.Model.Interface;

namespace FlightSimulator.Model
{
    class AutoPilotModel
    {
        private static AutoPilotModel m_Instance = null;
        public static AutoPilotModel Instance
        {
            get
            {
                if(m_Instance == null)
                {
                    m_Instance = new AutoPilotModel();
                }
                return m_Instance;
            }
        }

        ITelnetClient client = FlightTelnetClient.Instance;
        public void sendCommands(string value)
        {
            client.write(value);
        }
    }
}
