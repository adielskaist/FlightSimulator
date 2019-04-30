using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FlightSimulator.Model;

namespace FlightSimulator.ViewModels.Windows
{
    class AutoPilotViewModel : BaseNotify
    {
        private AutoPilotModel model = AutoPilotModel.Instance;
        private string massage = "";
        private bool isOk = false;

        public string Massage
        {
            get
            {
                return massage;
            }
            set
            {
                massage = value;
                NotifyPropertyChanged("Massage");
                NotifyPropertyChanged("Color");
            }
        }


        public string Color
        {
            get
            {
                if (massage != "")
                {
                    if (!isOk)
                    {
                        return "Pink";
                    }
                    isOk = false;
                }
                return "White";
            }
        }
        
        #region commands
        #region Ok command

        private ICommand _OkCommand;
        public ICommand OkCommand
        {
            get
            {
                return _OkCommand ?? (_OkCommand = new CommandHandler(() => OkKlickedOn()));
            }
        }
        private void OkKlickedOn()
        {
            model.sendCommands(massage + "\r\n");
            isOk = true;
            NotifyPropertyChanged("Color");
        }

        #endregion
        #region clear command
        private ICommand _ClearCommand;
        public ICommand ClearCommand
        {
            get
            {
                return _ClearCommand ?? (_ClearCommand = new CommandHandler(() => ClearKlickedOn()));
            }
        }
        private void ClearKlickedOn()
        {
            massage = "";
            NotifyPropertyChanged("Massage");
            NotifyPropertyChanged("Color");
        }
        #endregion
        #endregion

    }
}
