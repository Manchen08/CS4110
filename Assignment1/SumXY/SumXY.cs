using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumXY
{
    class SumXY
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter a number.");
                return 1;
            }

            int num;
            bool test = int.TryParse(args[0], out num);
            if (test == false)
            {

                System.Console.WriteLine("Please enter a number.");
                return 1;
            }

            //Integers 17 and 43 are in SumXY
            //If x and y are in SumXY, then so is x + y

            var sum = new SumXY();
            bool result;
            result = sum.inSumXY(num);
            Console.WriteLine("X = {0} Member?  {1}", num, result);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            return 0;
        }

        public bool inSumXY(int x)
        {
            if(x == 17)
                return true;

            if (x == 43)
                return true;

            if (x < 17)
                return false;

            return (inSumXY(x - 17) || inSumXY(x - 43));
        }
    }
}
