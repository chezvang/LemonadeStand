using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    class Lemons
    {
        private int lemons;

        public void CheckLemons()
        {
            Console.WriteLine("Lemons: " + lemons);
        }

        public int AddLemons(int purchaseAmount)
        {
            lemons += purchaseAmount;
            return lemons;
        }

        public int SubtractLemon(int subtract)
        {
            lemons -= subtract;
            return lemons;
        }

        public int SpoilLemons()
        {
            if (lemons <= 0)
            {
                return lemons;
            }
            else
            {
                lemons = lemons / 2;
                return lemons;
            }
        }
    }
}
