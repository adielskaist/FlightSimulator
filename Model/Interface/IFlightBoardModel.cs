using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FlightSimulator.Model.Interface
{
    interface IFlightBoardModel : INotifyPropertyChanged
    {
        void ReadFromServer();
        double Lon { get; set; }
        double Lat { get; set; }

        void Disconnect();
    }
}
