using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.Model.Interface;

namespace FlightSimulator.Model
{
    class MainWindowModel
    {
        #region Singleton
        private static MainWindowModel m_Instance = null;

        public static MainWindowModel Instance
        {
            get
            {
                if(m_Instance == null)
                {
                    m_Instance = new MainWindowModel();
                }
                return m_Instance;
            }
        }
        #endregion

        /// <summary>
        /// connecting to the simulator (client and server) and starting to read from the server
        /// </summary>
        public void Connect()
        {
            ISettingsModel settings = ApplicationSettingsModel.Instance;
            ITelnetServer server = DataReaderServer.Instance;
            ITelnetClient client = FlightTelnetClient.Instance;
            server.Connect(settings.FlightServerIP,settings.FlightInfoPort);
            client.connect(settings.FlightServerIP, settings.FlightCommandPort);
            FlightBoardModel.Instance.ReadFromServer();
        }

        /// <summary>
        /// opening a setting window
        /// </summary>
        public void OpenSettings()
        {
            Settings settingsWindow = new Settings();
            settingsWindow.Show();
        }

        /// <summary>
        /// disconnecting from the simulator
        /// </summary>
        public void Disconnect()
        {
            FlightTelnetClient.Instance.Disconnect();
            DataReaderServer.Instance.Disconnect();
            FlightBoardModel.Instance.Disconnect();
        }
    }
}
