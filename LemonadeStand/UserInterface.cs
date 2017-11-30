using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {

        public void ConstUi()
        {
            //blank constructor for ui's
        }

        public void DisplayIntro()
        {
            Console.WriteLine("Welcome to Lemonade Stand!\n");
        }

        public void DisplayGameInfo()
        {
            Console.WriteLine("Game info here\n");
            Console.ReadKey();
            Console.Clear();
        }

        public void DisplayMainMenu()
        {
            Console.WriteLine("");
        }

        public void DisplayProfit()
        {

        }

        public void DisplayWeather()
        {

        }

        public void PromptRecipe()
        {
            Console.WriteLine("Set your recipe for the day");
            Console.WriteLine("Remember, whatever you set will be used for every new pitcher. New pitchers are created after the amount of cups run out for it.");
        }
    }
}
