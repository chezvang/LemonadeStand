using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //name
        //inherit inventory
        Inventory inventory;

        public Player()
        {
            inventory = new Inventory();
        }

        public new void PlayerOneInventory()
        {
            inventory.PlayerInventory();
            inventory.PlayerWallet();
        }
    }
}
