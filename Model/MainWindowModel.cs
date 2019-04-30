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

        public void Connect()
        {
            ISettingsModel settings = ApplicationSettingsModel.Instance;
            ITelnetServer server = DataReaderServer.Instance;
            ITelnetClient client = FlightTelnetClient.Instance;
            server.connect(settings.FlightServerIP,settings.FlightInfoPort);
            client.connect(settings.FlightServerIP, settings.FlightCommandPort);
            
            FlightBoardModel.Instance.ReadFromServer();
        }

        public void OpenSettings()
        {
            Settings settingsWindow = new Settings();
            settingsWindow.Show();
        }

        public void close()
        {
            FlightTelnetClient.Instance.disconnect();
            DataReaderServer.Instance.disconnect();
            FlightBoardModel.Instance.Disconnect();
        }
    }
}
