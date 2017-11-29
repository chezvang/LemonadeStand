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
        public int purchaseAmount;
        public int totalAmount;
        public int itemPrice;

        public void PurchaseSupplies()
        {
            PurchasePrompt();
            PurchaseOptions(playerChoice);
            PurchaseCalculation(playerChoice, purchaseAmount);

        }

        public void PurchasePrompt()
        {
            Console.WriteLine("What do you want to buy? \nUse the number next to the item you want to purchase:");
            Console.WriteLine("[1] Lemons  | $2.00 ea \n[2] Sugar   | $1.00 ea \n[3] Cups    | $1.00 ea \n[4] Ice     | $1.00 ea");
            playerChoice = Console.ReadLine();
        }

        public void AmountToPurchase(string playerChoice)
        {
            Console.WriteLine("How many " + playerChoice + " do you want to purchase? \nEnter Amount:");
            purchaseAmount = Convert.ToInt32(Console.ReadLine());
        }

        public void PurchaseCalculation(string playerChoice, int purchaseAmount)
        {
            totalAmount = purchaseAmount * itemPrice;

            Console.WriteLine("You purchased " + purchaseAmount + " " + playerChoice + " for a total of $" + totalAmount);
        }

        public string PurchaseOptions(string playerChoice)
        {
            switch (playerChoice)
            {
                case "lemons":
                    playerChoice = "Lemons";
                    itemPrice = 3;
                    AmountToPurchase(playerChoice);
                    break;
                case "2":
                    playerChoice = "cups of Sugar";
                    itemPrice = 1;
                    AmountToPurchase(playerChoice);
                    break;
                case "3":
                    playerChoice = "Cups";
                    itemPrice = 1;
                    AmountToPurchase(playerChoice);
                    break;
                case "4":
                    playerChoice = "bags of Ice";
                    itemPrice = 2;
                    AmountToPurchase(playerChoice);
                    break;
                default:
                    Console.WriteLine("Please select one of the options available to you.");
                    PurchasePrompt();
                    break;
            }
            return playerChoice;
        }
    }
}
