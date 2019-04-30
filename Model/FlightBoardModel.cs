using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.Model.Interface;
using FlightSimulator.Model;
using System.ComponentModel;
using System.Threading;

namespace FlightSimulator.Model
{
    class FlightBoardModel : IFlightBoardModel
    {
        private static IFlightBoardModel m_Instance = null;
        public static IFlightBoardModel Instance
        {
            get
            {
                if(m_Instance == null)
                {
                    m_Instance = new FlightBoardModel();
                }
                return m_Instance;
            }
        }
        ITelnetServer server = DataReaderServer.Instance;
        private bool disconnected = false;
        public void Disconnect()
        {
            disconnected = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        public void ReadFromServer()
        {
            new Thread(() =>
            {
                disconnected = false;
                while (!disconnected)
                {
                    try
                    {
                            string line = server.read();
                            Console.WriteLine(line);
                            string[] info = line.Split(',');
                            Lon = Double.Parse(info[0]);
                            Lat = Double.Parse(info[1]);
                        Thread.Sleep(100);
                    } catch(NullReferenceException e) { Console.WriteLine("not connected yet"); }
                }
            }).Start();
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
                NotifyPropertyChanged("Lon");
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
                NotifyPropertyChanged("Lat");
            }
        }
    }
}
