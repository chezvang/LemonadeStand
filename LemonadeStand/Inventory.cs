using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public double money;
        Dictionary<string, int> inventory;

        //lemons, sugar, ice cubes, cups
        //public void PlayerOneInventory()
        //{
        //    var inventory = new Dictionary<string, int>();
        //    {
        //        inventory["Lemons"] = 0;
        //        inventory["Sugar"] = 0;
        //        inventory["Ice Cubes"] = 0;
        //        inventory["Cups"] = 0;

        //        foreach (KeyValuePair<string, int> item in inventory)
        //        {
        //            Console.WriteLine(item.Key + ": " + item.Value);
        //        }
        //    }
        //}

            public void PlayerInventory()
        {
            Wallet wallet = new Wallet();
            Lemons lemons = new Lemons();
            Sugar sugar = new Sugar();
            Cups cups = new Cups();
            IceCube iceCube = new IceCube();
        }

        public void PlayerWallet()
        {
            money = 20.00;
        }

        public void DisplayPlayerWallet()
        {
            Console.WriteLine("Player cash: $" + money);
        }

        public void CalculateWallet(double number)
        {
            money = money - number;
        }
    }
}
