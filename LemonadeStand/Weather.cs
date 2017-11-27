using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{    
    class Weather
    {
        public string weather;

        Random random = new Random();
        int weatherResult;
        string displayWeather;
        string tempStringResult;

        public void GenerateWeather()
        {
            weatherResult = random.Next(1, 5);
            ResultWeather();
        }

        public void ResultWeather()
        {
            switch(weatherResult)
            {
                case 1:
                    displayWeather = "Hazy";
                    break;
                case 2:
                    displayWeather = "Rain";
                    break;
                case 3:
                    displayWeather = "Overcast";
                    break;
                default:
                    displayWeather = "Sunny";
                    break;
            }
        }

        public void DisplayWeather()
        {
            Console.WriteLine("Today's weather forecast is " + displayWeather + ".");
            return;
        }

        public void GenerateTemp()
        {
            int tempResult = random.Next(50, 100);
            ConvertTemp(tempResult);
        }

        public void ConvertTemp(int tempResult)
        {
            tempStringResult = Convert.ToString(tempResult);
        }

        public void DisplayTemp()
        {
            Console.WriteLine("The temperature for today is " + tempStringResult + ".");
            return;
        }

    }
}
