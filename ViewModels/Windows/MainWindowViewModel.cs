using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FlightSimulator.Model;

namespace FlightSimulator.ViewModels.Windows
{
    class MainWindowViewModel : BaseNotify
    {
        MainWindowModel model = MainWindowModel.Instance;


        #region commands
        #region settings command
        private ICommand _SettingsCommand;
        public ICommand SettingsCommand
        {
            get
            {
                return _SettingsCommand ?? (_SettingsCommand = new CommandHandler(() => SettingsKlickedOn()));
            }
        }


        private void SettingsKlickedOn()
        {
            model.OpenSettings();
        }
        #endregion
        #region connect command
        private ICommand _ConnectCommand;
        public ICommand ConnectCommand
        {
            get
            {
                return _ConnectCommand ?? (_ConnectCommand = new CommandHandler(() => ConnectKlickedOn()));
            }
        }

        private void ConnectKlickedOn()
        {
            model.Connect();
        }
        #endregion
        #region disconnect command
        private ICommand _DisconnectCommand;
        public ICommand DisconnectCommand
        {
            get
            {
                return _DisconnectCommand ?? (_DisconnectCommand = new CommandHandler(() => DisconnectCommandKlicked()));
            }
        }

        private void DisconnectCommandKlicked()
        {
            model.Disconnect();
        }
        #endregion
        #endregion
    }
}
