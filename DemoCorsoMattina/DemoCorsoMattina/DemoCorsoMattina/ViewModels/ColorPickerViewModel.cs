using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace DemoCorsoMattina.ViewModels
{
    public class ColorPickerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double hue, saturation, luminosity;
        Color color;

        public Color CalculatedColor
        {
            get { return color; }
            set
            {
                if(color != value)
                {
                    color = value;
                    OnPropertyChanged("CalculatedColor");
                    Hue = value.Hue;
                    Saturation = value.Saturation;
                    Luminosity = value.Luminosity;
                }
            }
        }

        public double Hue
        {
            get { return hue; }
            set { 
                if(hue != value) 
                { 
                    hue = value;
                    OnPropertyChanged("Hue");
                    SetNewColor();
                }
            }
        }

        public double Saturation
        {
            get { return saturation; }
            set
            {
                if (saturation != value)
                {
                    saturation = value;
                    OnPropertyChanged("Saturation");
                    SetNewColor();
                }
            }
        }

        public double Luminosity
        {
            get { return luminosity; }
            set
            {
                if (luminosity != value)
                {
                    luminosity = value;
                    OnPropertyChanged("Luminosity");
                    SetNewColor();
                }
            }
        }

        public void OnPropertyChanged([CallerMemberName]
        string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }

        private void SetNewColor()
        {
            CalculatedColor = Color.FromHsla(Hue, Saturation, Luminosity);
        }
    }
}
