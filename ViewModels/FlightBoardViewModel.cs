using FlightSimulator.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.Model;


namespace FlightSimulator.ViewModels
{
    public class FlightBoardViewModel : BaseNotify
    {
        IFlightBoardModel model = FlightBoardModel.Instance;
        public FlightBoardViewModel()
        {
            model.PropertyChanged += Model_PropertyChanged;
        }
        

        private void Model_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("Lon"))
            {
                Lon = model.Lon;
            }
            if (e.PropertyName.Equals("Lat"))
            {
                Lat = model.Lat;
            }
        }

        private double lon;
        public double Lon
        {
            get
            {
                return lon;
            }
            set
            {
                lon = value;
                this.NotifyPropertyChanged("Lon");
            }
        }

        private double lat;
        public double Lat
        {
            get
            {
                return lat;
            }
            set
            {
                lat = value;
                this.NotifyPropertyChanged("Lon");
            }
        }

        public void ReadInfo()
        {
            model.ReadFromServer();
        }
    }
}
