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
        Player playerOne;
        //Player playerTwo;
        //Player comPlayer;
        //Day day;
        Weather weather;
        Store store;

        public void StartGame() //game constructor
        {
            ui = new UserInterface();
            playerOne = new Player();
            //day = new Day();
            weather = new Weather();
            store = new Store();
            //customer = new Customer();
        }

        public void RunGame()
        {
            ui.DisplayIntro();
            ui.DisplayGameInfo();
            playerOne.PlayerWallet();
            NewDay();
            DisplayInformation();
            PurchasePhase();
        }

        public void NewDay()
        {
            weather.GenerateTemp();
            weather.GenerateWeather();
        }

        public void DisplayInformation()
        {
            playerOne.DisplayPlayerWallet();
            playerOne.PlayerOneInventory();
            weather.DisplayTemp();
            weather.DisplayWeather();
        }

        public void PurchasePhase()
        {
            store.PurchaseSupplies();

        }

        public void CustomerPhase()
        {

        }

        public void CalculationPhase()
        {
            
        }
    }
}
