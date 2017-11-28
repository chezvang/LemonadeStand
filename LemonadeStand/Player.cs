using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player : Inventory
    {
        //name
        //inherit inventory
        //public string name;
        //public int money;
        Inventory inventory;

        public Player()
        {
            inventory = new Inventory();
        }

        public void PlayerOneInventory()
        {
            inventory.PlayerOneInventory();
            inventory.PlayerWallet();
        }
    }
}
