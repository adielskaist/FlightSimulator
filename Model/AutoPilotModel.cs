using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.Model.Interface;

namespace FlightSimulator.Model
{
    /// <summary>
    /// The auto pilot model.
    /// </summary>
    class AutoPilotModel
    {
        #region Singleton
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
        #endregion

        ITelnetClient client = FlightTelnetClient.Instance; //calling a client instance.
        /// <summary>
        /// sending commands to the simulator.
        /// </summary>
        /// <param name="msg">the massage sent</param>
        public void sendCommands(string msg)
        {
            client.write(msg);
        }
    }
}
