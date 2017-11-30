using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar
    {
        public int sugar;

        public void CheckSugar()
        {
            Console.WriteLine("Sugar: " + sugar);
        }

        public int AddSugar(int purchaseAmount)
        {
            sugar += purchaseAmount;
            return sugar;
        }

    }
}
