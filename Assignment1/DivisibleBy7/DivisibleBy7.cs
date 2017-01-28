using DivisibleBy7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy7
{
    class DivisibleBy7
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


            // Integer 7 is in DivisibleBy7
            // If x is in DivisibleBy7, then so is x + 7 
            var div7 = new DivisibleBy7();
            bool result;
            result = div7.inDivisibleBy7(num);

            Console.WriteLine("X = {0} Member?  {1}", num, result);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            return 0;
        }

        public bool inDivisibleBy7(int x)
        {
            if (x == 7)
            {
                return true;
            }
            if (x < 7)
            {
                return false;
            }

            return inDivisibleBy7(x - 7);
        }
    }
}
