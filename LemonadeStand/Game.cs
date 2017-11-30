using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        UserInterface ui;
        Player player;
        Day day;
        Weather weather;
        //Store store;
        Recipe recipe;
        Inventory inventory;
        Wallet wallet;
        Lemons lemons;
        Sugar sugar;
        Cups cups;
        IceCube iceCube;

        int gameTemperature;
        string gameWeather;

        public string playerChoice;
        public int purchaseAmount;
        public double totalAmount;
        public double itemPrice;

        public string response;

        public int dayCounter = 1;

        public void StartGame()
        {
            //inventory = new Inventory(); test, needed?
            ui = new UserInterface();
            player = new Player();
            wallet = new Wallet();
            day = new Day();
            weather = new Weather();
            //store = new Store();
            recipe = new Recipe();
            lemons = new Lemons();
            sugar = new Sugar();
            cups = new Cups();
            iceCube = new IceCube();

            ui.DisplayIntro();
            ui.DisplayGameInfo();
            wallet.StartGameWallet(20);
        }

        public void RunGame()
        {
            NewDay();
            DisplayInformation();
            PurchasePhase();
            wallet.DisplayPlayerWallet();
            lemons.CheckLemons();
            sugar.CheckSugar();
            cups.CheckCups();
            iceCube.CheckIceCube();
        }

        public void NewDay()
        {
            gameTemperature = weather.GenerateTemp();
            //gameWeather = weather.GetWeather();
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Day: " + dayCounter);
            wallet.DisplayPlayerWallet();
            lemons.CheckLemons();
            sugar.CheckSugar();
            cups.CheckCups();
            iceCube.CheckIceCube();

            weather.DisplayTemp();
            weather.DisplayWeather();
        }

        public void DisplayItems()
        {
            wallet.DisplayPlayerWallet();
            lemons.CheckLemons();
            sugar.CheckSugar();
            cups.CheckCups();
            iceCube.CheckIceCube();
        }

        public void PurchasePhase()
        {
            PurchasePrompt();
            PurchaseOptions(playerChoice);
            PurchaseCalculation(playerChoice, purchaseAmount);
            PurchaseAgain();
        }

        public void PurchasePrompt()
        {
            Console.WriteLine("What do you want to buy? \nUse the number next to the item you want to purchase:");
            Console.WriteLine("[1] Lemons  | $0.75 ea \n[2] Sugar   | $0.50 ea \n[3] Cups    | $0.50 ea \n[4] Ice     | $0.50 ea");
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
                    itemPrice = .75;
                    AmountToPurchase(playerChoice);
                    break;
                case "2":
                    playerChoice = "cups of Sugar";
                    itemPrice = .50;
                    AmountToPurchase(playerChoice);
                    break;
                case "3":
                    playerChoice = "Cups";
                    itemPrice = .25;
                    AmountToPurchase(playerChoice);
                    break;
                case "4":
                    playerChoice = "bags of Ice";
                    itemPrice = .50;
                    AmountToPurchase(playerChoice);
                    break;
                default:
                    Console.WriteLine("Please select one of the options available to you.");
                    PurchasePrompt();
                    break;
            }
            return playerChoice;
        }

        public void PurchaseAgain()
        {
            Console.WriteLine("Do you wish to purchase more items? y/n");
            response = Console.ReadLine();
            yesOrNo(response);
        }

        public void yesOrNo(string reponse)
        {
            switch (response)
            {
                case "y":
                    Console.Clear();
                    DisplayItems();
                    PurchasePhase();
                    break;
                case "n":
                    Console.Clear();
                    RecipePhase();
                    break;
                default:
                    yesOrNo(response);
                    break;
            }
        }

        public void RecipePhase()
        {
            ui.PromptRecipe();
            recipe.SetRecipe();
        }

        public void CustomerPhase()
        {

        }

        public void CalculationPhase()
        {

            dayCounter++;
        }

        public void DecayPhase()
        {

        }

        public void DayCheck()
        {

            Console.WriteLine(dayCounter); //show day
        }
    }
}
