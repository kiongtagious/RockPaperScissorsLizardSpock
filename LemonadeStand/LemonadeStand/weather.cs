using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class weather
    {
        public string getWeather;
        public string currentWeather;
        public int getTemperature;
        public int currentTemperature;
        public string tomorrowsWeather;
        public int tomorrowsTemperature;
        Random randomWeather = new Random();
        public weather()
        {
            getWeather = SetWeather();
            currentWeather = getWeather;
            getTemperature = SetTemperature();
            currentTemperature = getTemperature;
            tomorrowsWeather = SetWeather();
            tomorrowsTemperature = SetTemperature();
        }
        public string SetWeather()
        {
            int weather = randomWeather.Next(1, 4);
            switch (weather)
            {
                case 1:
                    getWeather = "Sunny Day";
                    break;
                case 2:
                    getWeather = "Rainy Day";
                    break;
                case 3:
                    getWeather = "Cloudy Day";
                    break;
            }
            return getWeather;
        }
        public int SetTemperature()
        {
            Random randomTemperature = new Random();
            getTemperature = randomTemperature.Next(45, 100);
            return getTemperature;
        }
        public int ChangeWeather()
        {
            if (getWeather == "Rainy Day")
            {
                currentTemperature = currentTemperature - 10;
                return currentTemperature;
            }
            else if (getWeather == "Cloudy Day")
            {
                currentTemperature = currentTemperature - 5;
                return currentTemperature;
            }
            else
            {
                currentTemperature = currentTemperature + 5;
                return currentTemperature;
            }
        }
        public void SetCurrentWeather()
        {
            currentWeather = tomorrowsWeather;
            currentTemperature = tomorrowsTemperature;
            tomorrowsWeather = SetWeather();
            tomorrowsTemperature = SetTemperature();
        }
    }
}
