using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.ViewModels;
using FlightSimulator.Model.Interface;
using FlightSimulator.Model;

namespace FlightSimulator.ViewModels
{
    class ManualPilotViewModel : BaseNotify
    {
        private ManualPilotModel model = ManualPilotModel.Instance;
        public double Rudder {
            set { model.Rudder = value; }
        }
        public double Throttle
        {
            set { model.Throttel = value; }
        }
        public double Alieron
        {
            set { model.Aileron = value; }
        }
        public double Elevator
        {
            set { model.Elevator = value; }
        }
    }
}
