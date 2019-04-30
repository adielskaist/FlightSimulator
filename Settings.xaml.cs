﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FlightSimulator.ViewModels;
using FlightSimulator.ViewModels.Windows;
using FlightSimulator.Model;

namespace FlightSimulator
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        BaseNotify viewModel = new SettingsWindowViewModel(new ApplicationSettingsModel());
        public Settings()
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}