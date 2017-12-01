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
        Weather weather;
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

        public int lemonsRecipe;
        public int sugarRecipe;
        public int iceCubeRecipe;

        public int cupsUsed;

        public int lemonsPitcher;
        public int sugarPitcher;
        public int iceCubePitcher;

        public int pitcherValue;

        public double price;

        public string response;

        public int customerAmount;

        public int customerBuy;
        public int customerNoBuy;
        public int customerTotal;

        public int dayTotalCustomers;
        public double dayTotalProfit;
        public double dayTotalDebt;

        public int overallBuyCustomer;
        public int overallNoBuyCustomer;
        public int overallTotalCustomer;
        public double overallProfit;
        public double overallDebt;

        public int dayCounter = 1;

        public void StartGame()
        {
            //inventory = new Inventory(); test, needed?
            ui = new UserInterface();
            player = new Player();
            wallet = new Wallet();
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

        public void NewDay()
        {
            gameTemperature = weather.GenerateTemp();
            weather.GenerateWeather();
            Console.WriteLine("Day: " + dayCounter);
            gameWeather = weather.DisplayWeather();
            weather.DisplayTemp();
        }

        public void DisplayInformation()
        {
            wallet.DisplayPlayerWallet();
            lemons.CheckLemons();
            sugar.CheckSugar();
            cups.CheckCups();
            iceCube.CheckIceCube();
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
            Console.WriteLine("What do you want to buy? \nType the name of the item you want to purchase:");
            Console.WriteLine("[ Lemons ] | $0.50 ea \n[ Sugar ]  | $0.25 ea \n[ Cups ]   | $0.20 ea \n[ Ice ]    | $0.25 ea \n[ None ]   | Continue to store");
            playerChoice = Console.ReadLine();
        }

        public void AmountToPurchase(string playerChoice)
        {
            Console.WriteLine("\nHow much do you want to purchase? \nEnter Amount:");
            purchaseAmount = Convert.ToInt32(Console.ReadLine());
        }

        public void PurchaseCalculation(string playerChoice, int purchaseAmount)
        {
            totalAmount = purchaseAmount * itemPrice;

            Console.WriteLine("\nYou purchased " + purchaseAmount + " " + playerChoice + " for a total of $" + totalAmount);

            ItemValues(playerChoice, totalAmount);
        }

        public void ItemValues(string playerChoice, double totalAmount)
        {
            switch (playerChoice)
            {
                case "Lemons":
                    lemons.AddLemons(purchaseAmount);
                    wallet.CalculateWallet(totalAmount);
                    dayTotalDebt += totalAmount;
                    break;
                case "Sugar":
                    sugar.sugar = sugar.sugar += purchaseAmount;
                    wallet.CalculateWallet(totalAmount);
                    return;
                case "Cups":
                    cups.cups = cups.cups += purchaseAmount;
                    wallet.CalculateWallet(totalAmount);
                    return;
                case "Ice":
                    iceCube.iceCube = iceCube.iceCube += purchaseAmount;
                    wallet.CalculateWallet(totalAmount);
                    return;
                case "None":

                    break;
                default:
                    Console.WriteLine("This thing broke");
                    break;
            }
        }

        public string PurchaseOptions(string playerChoice)
        {
            switch (playerChoice)
            {
                case "Lemons":
                    itemPrice = .50;
                    AmountToPurchase(playerChoice);
                    break;
                case "Sugar":
                    itemPrice = .25;
                    AmountToPurchase(playerChoice);
                    break;
                case "Cups":
                    itemPrice = .20;
                    AmountToPurchase(playerChoice);
                    break;
                case "Ice":
                    itemPrice = .25;
                    AmountToPurchase(playerChoice);
                    break;
                case "None":

                    break;
                default:
                    Console.WriteLine("Please select one of the options available to you.");
                    ui.ClickToContinue();
                    PurchasePhase();
                    break;
            }
            return playerChoice;
        }

        public void PurchaseAgain()
        {
            Console.WriteLine("Do you wish to purchase more items? (y)Yes / (n)No");
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
                    break;
                default:
                    string blank = null;
                    yesOrNo(blank);
                    break;
            }
        }

        public void RecipePhase()
        {
            ui.PromptRecipe();
            SetRecipe();
        }

        public void SetRecipe()
        {
            Console.WriteLine("\nHow would you like to set your recipe?");
            Console.WriteLine("\nEnter the amount of lemons to add");
            lemonsRecipe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the amount of sugar to add");
            sugarRecipe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the amount of ice cubes to add");
            iceCubeRecipe = Convert.ToInt32(Console.ReadLine());
            SetPitcher(lemonsRecipe, sugarRecipe, iceCubeRecipe);
        }

        public void SetPitcher(int lemonsRecipe, int sugarRecipe, int iceCubeRecipe)
        {
            lemonsPitcher += lemonsRecipe * 2;
            lemons.SubtractLemon(lemonsRecipe);

            sugarPitcher += sugarRecipe;
            sugar.SubtractSugar(sugarRecipe);

            iceCubePitcher += iceCubeRecipe;
            iceCube.SubtractIceCube(iceCubeRecipe);

            pitcherValue = (lemonsPitcher + sugarPitcher) - iceCubePitcher;

            PitcherCheck();
        }

        public void PitcherCheck()
        {
            if (pitcherValue <= 0)
            {
                pitcherValue = 0;
            }
            else
            {
                return;
            }
        }

        public void SetPrice()
        {
            Console.Clear();
            Console.WriteLine("\nSet your price for your lemonade per cup");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your price per cup has been set to $" + price);
        }

        public void CustomerPhase()
        {
            CustomerWeather();
            CustomerLoop();
            DisplayInformation();
        }

        public void CustomerWeather()
        {
            Random random = new Random();
            switch (gameWeather)
            {
                case "Hazy":
                    customerAmount = random.Next(60, 90);
                    break;
                case "Rain":
                    customerAmount = random.Next(35, 75);
                    break;
                case "Overcast":
                    customerAmount = random.Next(45, 85);
                    break;
                default:
                    customerAmount = random.Next(80, 120);
                    break;
            }
        }

        public void CustomerLoop()
        {
            for (int i = 1; i < customerAmount; i++)
            {
                CustomerVariant();
            }
        }

        public void CustomerVariant()
        {
            Random random = new Random();
            int customerBuyChance = 100 + pitcherValue;
            int customerNoBuyChance = random.Next(1, 41);
            int temperatureChance = gameTemperature / 4;
            int weatherChance;

            weatherChance = weather.CustomerWeather(gameWeather);

            customerBuyChance = customerBuyChance - (customerNoBuyChance + temperatureChance);

            if (customerBuyChance >= 50 + weatherChance)
            {
                customerBuy++;
                overallBuyCustomer++;
                dayTotalCustomers++;
                CustomerPurchase();
            }
            else
            {
                customerNoBuy++;
                overallNoBuyCustomer++;
                dayTotalCustomers++;
            }
        }

        public void CustomerPurchase()
        {
            wallet.AddToWallet(price);
            CalculateOverallProfit(price);
            CalculateDayProfit(price);
            cups.SubtractCups(1);
        }

        public void CalculationPhase()
        {
            dayCounter++;

            CalculateTotalCustomers();
            DisplayDayProfit();
            DisplayRemainingInventory();
        }

        public void CalculateTotalCustomers()
        {
            customerTotal = customerBuy + customerNoBuy;
            Console.Clear();
            Console.WriteLine("You had " + customerBuy + " out of " + customerTotal + " customers today!\n");
            ui.ClickToContinue();
        }

        public void DisplayRemainingInventory()
        {
            Console.WriteLine("This is what remains of your inventory: ");
            DisplayItems();
            ui.ClickToContinue();
        }

        public void CalculateOverallProfit(double price)
        {
            overallProfit += price;
            overallProfit = overallProfit - overallDebt;
        }

        public void DisplayOverallProfit()
        {
            Console.WriteLine("Overall profit: $" + overallProfit);
            ui.ClickToContinue();
        }

        public void CalculateDayProfit(double price)
        {
            dayTotalProfit = price - dayTotalDebt;
        }

        public void DisplayDayProfit()
        {
            Console.WriteLine("Profit for the day: $" + dayTotalProfit);
            ui.ClickToContinue();
        }

        public void DecayPhase()
        {
            ResetValues();
            DecayIce();
            DecayLemons();
        }

        public void DecayIce()
        {
            Console.WriteLine("All of your ice melted!");
            iceCube.iceCube = 0;
            ui.ClickToContinue();
        }

        public void ResetValues()
        {
            pitcherValue = 0;
            dayTotalCustomers = 0;
            dayTotalProfit = 0;
            dayTotalDebt = 0;
        }

        public void DecayLemons()
        {
            Console.WriteLine("Some of your lemons spoiled");
            lemons.SpoilLemons();
            ui.ClickToContinue();
        }

        public void DayCheck()
        {

            if (dayCounter == 7)
            {
                Console.WriteLine("Let's see how you did!");
            }
            else
            {
                RunGame();
            }
           Console.WriteLine(dayCounter); //show day
        }

        public void RunGame()
        {
            NewDay();
            DisplayInformation();
            PurchasePhase();
            RecipePhase();
            SetPrice();
            CustomerPhase();
            CalculationPhase();
            DecayPhase();
            DayCheck();
        }
    }
}
