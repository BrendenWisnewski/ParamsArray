using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Util
    {
        public static int Sum(params int[] paramList)
        {
            Console.WriteLine("Using Parameters List");
            if (paramList == null)
            {
                throw new ArgumentException("Util.Sum: null parameter list");
            }
            if (paramList.Length == 0)
            {
                throw new ArgumentException("Util.Sum: empty parameter list");
            }

            int sumTotal = 0;

            foreach (var param in paramList)
            {
                sumTotal += param;
            }
            return sumTotal;
        }

        public static int Sum(int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0)
        {
            Console.WriteLine("Using Optional Parameters");
            int total = param1 + param2 + param3 + param4;
            return total;
        }
    }
}
