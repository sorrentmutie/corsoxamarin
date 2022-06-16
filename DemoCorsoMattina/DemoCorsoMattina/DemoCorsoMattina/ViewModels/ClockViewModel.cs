using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace DemoCorsoMattina.ViewModels
{
    public class ClockViewModel : INotifyPropertyChanged
    {
        private DateTime dateTime;
        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime DateTime
        {
            get { return dateTime; }
            set
            {
                if(dateTime != value)
                {
                    dateTime = value;

                    OnPropertyChanged();
                }
            }
        }

        public ClockViewModel()
        {
            DateTime = DateTime.Now;
            Device.StartTimer(TimeSpan.FromSeconds(1),
                () =>
                {
                    DateTime = DateTime.Now;
                    return true;
                });
        }

        public void OnPropertyChanged([CallerMemberName] 
        string propertyName = null)
        {
            PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
