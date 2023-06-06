using System;
using System.Windows.Media.Imaging;

namespace WeatherApp.Utilities
{
    public class WeatherSimpleData
    {
        public string Date { get; set; }
        public BitmapImage ConditionImg { get; set; }
        public string AvgTemperature { get; set; }
    }
}
