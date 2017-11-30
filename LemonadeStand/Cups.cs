using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cups
    {
        public int cups;

        public void CheckCups()
        {
            Console.WriteLine("Cups: " + cups);
        }

        public int AddCups(int purchaseAmount)
        {
            cups += purchaseAmount;
            return cups;
        }
    }
}
