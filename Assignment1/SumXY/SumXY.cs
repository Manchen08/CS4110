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

            if (num % 2 == 0)
            {
                System.Console.WriteLine("X = {0}  Member?  True", num);
            }
            else
            {
                System.Console.WriteLine("X = {0}  Member?  False", num);
            }
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            return 0;
        }
    }
}
