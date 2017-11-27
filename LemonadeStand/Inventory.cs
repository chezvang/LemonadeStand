using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract class Inventory
    {
        private int money;
        List<string> inventory;
        string[] lemonsInventory = new string[1];

        //lemons, sugar, ice cubes, cups
        public void PlayerInventory()
        {
            inventory = new List<string>() { "Lemons", "Sugar", "Ice Cubes", "Cups" };            
        }

        public void DisplayInventory()
        {

        }

        public void LemonsInventory()
        {
            
        }

        //public int LemonsInventory()
        //{

        //}

        public int PlayerWallet()
        {
            money = 20; //placeholder, add decimals
            return money;
        }

        public void DisplayPlayerWallet()
        {
            Console.WriteLine("Player cash: $" + money);
        }
    }
}
