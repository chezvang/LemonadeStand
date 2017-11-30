using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        public double money;

        public double StartGameWallet(int starterMoney)
        {
            money += starterMoney;
            return money;
        }

        public void DisplayPlayerWallet()
        {
            Console.WriteLine("Player cash: $" + money + "\n");           
        }

        public void CalculateWallet(double number)
        {
            money = money - number;
        }
    }
}
