﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlySim
{
    public class FlightInformation : Common.ObservableBase
    {
        public FlightInformation(double altitude)
        {
            this.DisplayName = "(initializing...)";
            this.CurrentAltitude = altitude;
        }

        private string _displayName;
        public string DisplayName
        {
            get { return this._displayName; }
            set { this.SetProperty(ref this._displayName, value); }
        }

        private double _currentPitch;
        public double CurrentPitch
        {
            get { return this._currentPitch; }
            set { this.SetProperty(ref this._currentPitch, value); }
        }

        private double _currentAltitude;
        public double CurrentAltitude
        {
            get { return this._currentAltitude; }
            set { this.SetProperty(ref this._currentAltitude, value); }
        }

        private double _currentHeading;
        public double CurrentHeading
        {
            get { return this._currentHeading; }
            set { this.SetProperty(ref this._currentHeading, value); }
        }

        private double _currentSpeed;
        public double CurrentSpeed
        {
            get { return this._currentSpeed; }
            set { this.SetProperty(ref this._currentSpeed, value); }
        }

        private double _currentTemperature;
        public double CurrentTemperature
        {
            get { return this._currentTemperature; }
            set { this.SetProperty(ref this._currentTemperature, value); }
        }

        private double _currentHumidity;
        public double CurrentHumidity
        {
            get { return this._currentHumidity; }
            set { this.SetProperty(ref this._currentHumidity, value); }
        }

        private double _currentRoll;
        public double CurrentRoll
        {
            get { return this._currentRoll; }
            set { this.SetProperty(ref this._currentRoll, value); }
        }

       

    }
}
