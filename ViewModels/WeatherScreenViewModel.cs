using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using WeatherApp.Utilities;
using WeatherApp.Utilities.Structs;

namespace WeatherApp.ViewModels
{
    public  class WeatherScreenViewModel : Conductor<object>
    {
        private string _city;
        private string _country;
        private string _temp;
        private string _avgTemp;
        private string _description;
        private BitmapImage _conditionImg;
        private BitmapImage _windspeedImg;
        private string _inputCity;
        private string _windspeed;
        private List<WeatherSimpleData> _weatherDays;
        private bool _loadingIcon;

        public string City 
        {
            get => _city;
            set
            {
                _city = value;
                NotifyOfPropertyChange(() => City);
            } 
        }
        public string Country 
        {
            get => _country;
            set
            {
                _country = value;
                NotifyOfPropertyChange(() => Country);
            }
        }
        public string Temp
        {
            get => _temp;
            set
            {
                _temp = value;
                NotifyOfPropertyChange(() => Temp);
            }
        }
        public string AvgTemp
        {
            get => _avgTemp;
            set
            {
                _avgTemp = value;
                NotifyOfPropertyChange( () => AvgTemp);
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                NotifyOfPropertyChange(() => Description);
            }
        }
        public BitmapImage ConditionImg
        {
            get => _conditionImg;
            set
            {
                _conditionImg = value;
                NotifyOfPropertyChange(() => ConditionImg);
            }
        }
        public BitmapImage WindspeedImg
        {
            get => _windspeedImg;
            set
            {
                _windspeedImg = value;
                NotifyOfPropertyChange(() => WindspeedImg);
            }
        }
        public string InputCity
        {
            get => _inputCity;
            set
            {
                _inputCity = value;
                NotifyOfPropertyChange( () => InputCity);
            }
        }
        public string Windspeed
        {
            get => _windspeed;
            set
            {
                _windspeed = value;
                NotifyOfPropertyChange(() => Windspeed);
            }
        }
        public List<WeatherSimpleData> WeatherDays
        {
            get => _weatherDays;
            set
            {
                _weatherDays = value;
                NotifyOfPropertyChange(() => WeatherDays);
            }
        }
        public bool LoadingIcon
        {
            get => _loadingIcon;
            set
            {
                _loadingIcon = value;
                NotifyOfPropertyChange(() => LoadingIcon);
            }
        }

        public WeatherScreenViewModel() 
        {
            LoadWeatherUI("Katowice");
        }

        private async void LoadWeatherUI(string city)
        {
            LoadingIcon = true;
            WeatherProvider weather = new WeatherProvider();
            var res = await weather.LoadWeather(city);

            if (!res)
            {
                MessageBox.Show("Nie można załadować danych pogody...", "Info");
                return;
            }

            LoadingIcon = false;
            WeatherData weatherData = weather.CurrentWeather;
            City = weatherData.City;
            Country = weatherData.Country;
            Temp = weatherData.Temp_C + "C°";
            Description = weatherData.Description;
            ConditionImg = WeatherProvider.GetIconWeatherByStatus(weatherData.Description.ToLower());
            AvgTemp = $"Avg temperature {weatherData.AvgTemp_C}C°";
            WindspeedImg = new BitmapImage(new Uri("https://static.vecteezy.com/system/resources/previews/022/287/827/original/3d-rendering-windsock-icon-3d-render-wind-direction-tool-icon-windsock-png.png"));
            Windspeed = weatherData.WindSpeedKm + "Km/H";
            WeatherDays = weatherData.WeatherDays;
        }

        public void LoadWeatherByCity()
        {
            if(!string.IsNullOrEmpty(InputCity))
                LoadWeatherUI(InputCity);
        }

        public void LoadWeatherByCity(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
                if (!string.IsNullOrEmpty(InputCity))
                    LoadWeatherUI(InputCity);
        }
    }
}
