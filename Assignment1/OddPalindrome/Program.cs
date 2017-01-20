using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddPalindrome
{
    class Program
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
            //Words a and b are in OddPalindrome.
            //If w is a word in OddPalindrome, then so are awa and bwb (concatenation).
            var pow = new PowersOf2();
            decimal result;

            if (result == 0)
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
