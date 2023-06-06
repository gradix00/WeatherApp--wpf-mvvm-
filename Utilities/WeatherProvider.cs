using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using WeatherApp.Utilities.Structs;
using System.Windows.Media.Imaging;
using System.Windows;

namespace WeatherApp.Utilities
{
    public class WeatherProvider
    {
        private WeatherData _currentWeather;

        public WeatherData CurrentWeather
        {
            get => _currentWeather;
            private set
            {
                _currentWeather = value;
            }
        }

        public async Task<bool> LoadWeather(string city)
        {
            try
            {
                HttpClient client = new HttpClient();
                string request = await client.GetStringAsync($"https://wttr.in/{city}?format=j1");

                if (string.IsNullOrEmpty(request))
                    return false;

                dynamic json = JsonConvert.DeserializeObject(request);
                WeatherData res = new WeatherData();
                res.Load(json);
                _currentWeather = res;
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public static BitmapImage GetIconWeatherByStatus(string status)
        {
            string url;
            switch (status)
            {
                case "thunderstorms":
                    url = "https://static.vecteezy.com/system/resources/previews/022/376/939/original/3d-icon-of-rain-and-a-thunderstorm-cloud-with-a-lightning-bolt-weather-icons-png.png";
                    break;
                case "cloudy":
                    url = "https://w7.pngwing.com/pngs/980/947/png-transparent-apps-storage-weather-cloud-cloudy-forecast-data-database-3d-icon.png";
                    break;
                case "partly cloudy":
                    url = "https://static.vecteezy.com/system/resources/previews/010/989/785/original/sunny-weather-3d-rendering-isolated-on-transparent-background-ui-ux-icon-design-web-and-app-trend-png.png";
                    break;
                case "moderate snow":
                    url = "https://cdn3d.iconscout.com/3d/premium/thumb/heavy-snow-7807873-6263304.png";
                    break;
                case "foggy":
                    url = "https://static.vecteezy.com/system/resources/previews/013/250/771/original/fog-cloud-3d-rendering-isometric-icon-png.png";
                    break;
                case "moderate rain":
                    url = "https://static.vecteezy.com/system/resources/previews/022/288/110/original/3d-rendering-rainy-weather-icon-3d-render-cloud-with-rain-rainy-weather-png.png";
                    break;
                default:
                    url = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/08/Weather_icon_-_sunny.svg/512px-Weather_icon_-_sunny.svg.png";
                    break;
            }
            return new BitmapImage(new Uri(url));
        }
    }
}
