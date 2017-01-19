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
                System.Console.WriteLine("Please enter a numeric argument.");
                System.Console.WriteLine("Usage: Factorial <num>");
                return 1;
            }

            return 0;
        }
    }
}
