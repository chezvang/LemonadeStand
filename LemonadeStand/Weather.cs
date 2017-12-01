using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
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
            switch (weatherResult)
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

        public virtual string DisplayWeather()
        {
            Console.WriteLine("Today's weather forecast is " + displayWeather);
            return displayWeather;
        }

        public int GenerateTemp()
        {
            int tempResult = random.Next(50, 100);
            ConvertTemp(tempResult);
            return tempResult;
        }

        public void ConvertTemp(int tempResult)
        {
            tempStringResult = Convert.ToString(tempResult);
        }

        public void DisplayTemp()
        {
            Console.WriteLine("The temperature for today is " + tempStringResult + " degrees.");
            return;
        }

        public int CustomerWeather(string gameWeather)
        {
            Random random = new Random();
            switch (gameWeather)
            {
                case "Hazy":
                    return random.Next(9, 21);
                case "Rain":
                    return random.Next(21, 36);
                case "Overcast":
                    return random.Next(5, 21);
                default:
                    return 0;
            }
        }
    }
}
