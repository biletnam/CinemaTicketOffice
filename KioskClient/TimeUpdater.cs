﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;
using DataAccess;

namespace KioskClient
{
    public class TimeUpdater : INotifyPropertyChanged
    {
        public TimeUpdater()
        {
            const int oneSecond = 1000;

            var timer = new Timer(oneSecond);
            timer.Elapsed += (sender, args) => OnPropertyChanged("Time");
            timer.Start();
        }

        public string Time
        {
            get { return DateTime.Now.ToShortTimeString(); }
        }

        public string Date
        {
            get { return DateTime.Now.ToString("d MMMM"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}