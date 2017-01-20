﻿using PowersOf2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersOf2
{
    class PowersOf2
    {
        static int Main(string[] args)
        {
            
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter a number.");
                return 1;
            }

            decimal num;
            bool test = decimal.TryParse(args[0], out num);
            if (test == false)
            {

                System.Console.WriteLine("Please enter a number.");
                return 1;
            }


            //Integer 1 is in PowersOf2
            //If x is in PowersOf2, then so is 2x.
            var pow = new PowersOf2();
            decimal result;
            result = pow.inPowersOf2(num);
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

        public decimal inPowersOf2(decimal x)
        {
            if(x == 1)
            {
                return 0;
            }


            if (x < 1)
                return 1;

            return (inPowersOf2(x / 2));
        }
    }
}
