using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        // Single Responsibility Principle
        // This method only displays "Welcome to Lemonade Stand".
        public void DisplayIntro()
        {
            Console.WriteLine("Welcome to Lemonade Stand!\n");
        }

        public void DisplayGameInfo()
        {
            Console.WriteLine("You get one week to prove yourself in the world of the lemonade stand business. If you lose the immense loan of $20 you're done!\n");
            ClickToContinue();
        }

        public void PromptRecipe()
        {
            Console.WriteLine("Set your recipe for the day\n");
            Console.WriteLine("Think carefully. You won't be able to change this recipe until the next day. Take into account the weather, temperature, and the price you set. Never give up. Trust your instincts! Unless you run out of money... ");
        }

        // Open/Closed Principle
        //Additional functionality can be added to this method, but if modified, will alter the purpose of the method.
        public void ClickToContinue()
        {
            Console.WriteLine("Click Enter to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
