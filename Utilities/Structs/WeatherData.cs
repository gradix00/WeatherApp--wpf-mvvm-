using System;
using System.Collections.Generic;

namespace WeatherApp.Utilities.Structs
{
    public struct WeatherData
    {
        public string City { get; set; }
        public string Country { get; set; }
        public float Temp_C { get; set; }
        public float Temp_F { get; set; }
        public float AvgTemp_C { get; set; }
        public float AvgTemp_F { get; set; }
        public string Description { get; set; }
        public float Pressure { get; set; }
        public float WindSpeedKm { get; set; }
        public float WindSpeedMiles { get; set; }
        public DateTime LocalDateTime { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        public string Moonrise { get; set; }
        public string Moonset { get; set; }
        public string MoonPhase { get; set; }
        public List<WeatherSimpleData> WeatherDays { get; set; }

        public void Load(dynamic data)
        {
            City = data.nearest_area[0].areaName[0].value;
            Country = data.nearest_area[0].country[0].value;
            Temp_C = data.current_condition[0].temp_C;
            Temp_F = data.current_condition[0].temp_F;
            AvgTemp_C = data.weather[0].avgtempC;
            AvgTemp_F = data.weather[0].avgtempF;
            Description = data.current_condition[0].weatherDesc[0].value;
            Pressure = data.current_condition[0].pressure;
            WindSpeedKm = data.current_condition[0].windspeedKmph;
            WindSpeedMiles = data.current_condition[0].windspeedMiles;
            LocalDateTime = Convert.ToDateTime(data.current_condition[0].localObsDateTime);
            Sunrise = data.weather[0].astronomy[0].sunrise;
            Sunset = data.weather[0].astronomy[0].sunset;
            Moonrise = data.weather[0].astronomy[0].moonrise;
            Moonset = data.weather[0].astronomy[0].moonset;
            MoonPhase = data.weather[0].astronomy[0].moon_phase;

            WeatherDays = new List<WeatherSimpleData>();
            for(int x = 0; x < 3; x++)
            {
                DateTime date = Convert.ToDateTime(data.weather[x].date);
                WeatherDays.Add(new WeatherSimpleData()
                {
                    Date = date.ToString("dd/MM/yyyy").Replace('/', '.'),
                    ConditionImg = WeatherProvider.GetIconWeatherByStatus("partly cloudy"),
                    AvgTemperature = data.weather[x].avgtempC + "C°"
                });
            }
        }
    }
}
