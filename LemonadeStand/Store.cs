using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public string playerChoice;

        public void PurchaseSupplies()
        {
            DisplayPurchasePrompt();
            PurchaseOptions();

        }

        public void DisplayPurchasePrompt()
        {
            Console.WriteLine("Enter the number for the desired item");
            Console.WriteLine("[1] Lemons \n[2] Sugar \n[3] Cups \n[4] Ice");
            string playerChoice = Console.ReadLine();
            PurchaseOptions();
        }

        public void AmountToPurchase()
        {

        }

        public void PurchaseOptions()
        {
            switch (playerChoice)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":

                    break;
                default:
                    Console.WriteLine("Please select one of the options available to you.");
                    DisplayPurchasePrompt();
                    break;
            }
        }

    }
}
