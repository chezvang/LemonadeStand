using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        private int money;
        //public string displayInventory;
        //List<string> inventory;
        Dictionary<string, int> inventory;

        //lemons, sugar, ice cubes, cups
        public void PlayerOneInventory()
        {
            var inventory = new Dictionary<string, int>();
            {
                inventory["Lemons"] = 0;
                inventory["Sugar"] = 0;
                inventory["Ice Cubes"] = 0;
                inventory["Cups"] = 0;

                foreach (KeyValuePair<string, int> item in inventory)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
        }

        //public void DisplayInventory()
        //{
        //    PlayerOneInventory();
        //    {
        //        foreach (KeyValuePair<string, int> pair in inventory)
        //        {
        //            Console.WriteLine(pair.Key, pair.Value);
        //        }
        //    }
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
