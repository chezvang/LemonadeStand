using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
     class IceCube
    {
         public int iceCube;

        public void CheckIceCube()
        {
            Console.WriteLine("Ice Cubes: " + iceCube + "\n");
        }

        public int AddIce(int purchaseAmount)
        {
            iceCube += purchaseAmount;
            return iceCube;
        }
        public int SubtractIceCube(int subtract)
        {
            iceCube -= subtract;
            return iceCube;
        }
    }
}
