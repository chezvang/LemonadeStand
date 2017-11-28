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
            //StringToIntConverter(purchaseAmount);
            PurchaseCalculation(playerChoice, purchaseAmount);

        }

        public void PurchasePrompt()
        {
            Console.WriteLine("Enter the number for the desired item:");
            Console.WriteLine("[1] Lemons  | $2.00 ea \n[2] Sugar   | $1.00 ea \n[3] Cups    | $1.00 ea \n[4] Ice     | $1.00 ea");
            string playerChoice = Console.ReadLine();
            PurchaseOptions(playerChoice);
        }

        public void AmountToPurchase(string playerChoice)
        {
            Console.WriteLine("How many " + playerChoice + " do you want to purchase? \nEnter Amount:");
            purchaseAmount = Convert.ToInt32(Console.ReadLine());
            return;
        }

        public void PurchaseCalculation(string playerChoice, int purchaseAmount)
        {
            totalAmount = purchaseAmount * itemPrice;

            Console.WriteLine("You purchased " + purchaseAmount + " " + playerChoice + " for a total of $" + totalAmount);
        }

        //public void StringToIntConverter(string convertToInt)
        //{
        //    this.purchaseAmount = Convert.ToInt32();
        //}

        public void PurchaseOptions(string playerChoice)
        {
            switch (playerChoice)
            {
                case "1":
                    playerChoice = "Lemons";
                    itemPrice = 2;
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
                    itemPrice = 1;
                    AmountToPurchase(playerChoice);
                    break;
                default:
                    Console.WriteLine("Please select one of the options available to you.");
                    PurchasePrompt();
                    break;
            }
        }

    }
}
