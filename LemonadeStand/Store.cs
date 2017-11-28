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
        public string purchaseAmount;

        public void PurchaseSupplies()
        {
            DisplayPurchasePrompt();
            PurchaseOptions(playerChoice);

        }

        public void DisplayPurchasePrompt()
        {
            Console.WriteLine("Enter the number for the desired item:");
            Console.WriteLine("[1] Lemons \n[2] Sugar \n[3] Cups \n[4] Ice");
            string playerChoice = Console.ReadLine();
            PurchaseOptions(playerChoice);
        }

        public void AmountToPurchase()
        {
            Console.WriteLine("How much do you want to purchase? \nEnter Amount:");
            purchaseAmount = Console.ReadLine();
        }

        public void PurchaseOptions(string playerChoice)
        {
            switch (playerChoice)
            {
                case "1": //lemons
                    AmountToPurchase();
                    break;
                case "2": //sugar

                    break;
                case "3": //cups

                    break;
                case "4": //ice

                    break;
                default:
                    Console.WriteLine("Please select one of the options available to you.");
                    DisplayPurchasePrompt();
                    break;
            }
        }

    }
}
