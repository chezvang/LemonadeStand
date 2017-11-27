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
        Day day;
        Weather weather;
        Store store;
        Customer customer;

        public void StartGame() //game constructor
        {
            ui = new UserInterface();
            playerOne = new Player();
            //day = new Day();
            weather = new Weather();
            //store = new Store();
            //customer = new Customer();
        }

        public void RunGame()
        {
            ui.DisplayIntro();
            ui.DisplayInfo();
            //playerOne.PlayerInventory();
            playerOne.PlayerWallet();
            weather.GenerateTemp();
            weather.GenerateWeather();
            DisplayInformation();
        }

        public void DisplayInformation()
        {
            playerOne.DisplayPlayerWallet();
            weather.DisplayTemp();
            weather.DisplayWeather();
        }

        public void Purchase()
        {

        }

        public void CalculateProfit()
        {
            
        }
    }
}
