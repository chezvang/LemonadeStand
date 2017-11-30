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
        public double totalAmount;
        public double itemPrice;
        //Inventory inventory
        Wallet wallet = new Wallet();
        Lemons lemons = new Lemons();
        Sugar sugar = new Sugar();
        Cups cups = new Cups();
        IceCube iceCube = new IceCube();

        public void PurchaseSupplies()
        {           
            PurchasePrompt();
            PurchaseOptions(playerChoice);
            PurchaseCalculation(playerChoice, purchaseAmount);
        }

        public void PurchasePrompt()
        {
            Console.WriteLine("What do you want to buy? \nUse the number next to the item you want to purchase:");
            Console.WriteLine("[1] Lemons  | $1.5 ea \n[2] Sugar   | $2.00 ea \n[3] Cups    | $1.00 ea \n[4] Ice     | $1.00 ea");
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

            ItemValues(playerChoice, totalAmount);
        }

        public void ItemValues(string playerChoice, double totalAmount)
        {
            switch (playerChoice)
            {
                case "1":
                    //lemons.lemons = lemons.lemons += purchaseAmount;
                    lemons.AddLemons(purchaseAmount);
                    wallet.CalculateWallet(totalAmount);
                    break;
                case "2":
                    sugar.sugar = sugar.sugar += purchaseAmount;
                    wallet.CalculateWallet(totalAmount);
                    return;
                case "3":
                    cups.cups = cups.cups += purchaseAmount;
                    wallet.CalculateWallet(totalAmount);
                    return;
                case "4":
                    iceCube.iceCube = iceCube.iceCube += purchaseAmount;
                    wallet.CalculateWallet(totalAmount);
                    return;
                default:
                    Console.WriteLine("This thing broke");
                    break;
            }
        }

        public string PurchaseOptions(string playerChoice)
        {
            switch (playerChoice)
            {
                case "1":
                    playerChoice = "Lemons";
                    itemPrice = 1.50;
                    AmountToPurchase(playerChoice);
                    break;
                case "2":
                    playerChoice = "cups of Sugar";
                    itemPrice = .75;
                    AmountToPurchase(playerChoice);
                    break;
                case "3":
                    playerChoice = "Cups";
                    itemPrice = .50;
                    AmountToPurchase(playerChoice);
                    break;
                case "4":
                    playerChoice = "bags of Ice";
                    itemPrice = .90;
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
