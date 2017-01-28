using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddPalindrome
{
    class OddPalindrome
    {
        static int Main(string[] args)
        {
            if (args[0] == null)
            {
                Console.WriteLine("Please enter a string of a's and b's.");
            }
            string s = args[0];
            //Words a and b are in OddPalindrome.
            //If w is a word in OddPalindrome, then so are awa and bwb (concatenation).
            var p = new OddPalindrome();
            bool result = p.inOddPalindrome(s);
            Console.WriteLine("String = {0} Member?  {1}", s, result);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            return 0;
        }

        public bool inOddPalindrome(string w)
        {
            // If it's length of 1 it is always true.
            if (w.Length == 1)
            {
                if (w == "a" || w == "b")
                    return true;
                else
                    return false;
            }

            // If it's not odd then it's false.
            if (w.Length % 2 == 0)
            {
                return false;
            }

            char s = w[0];
            char e = w[w.Length - 1];

            //Check for proper chars
            if(s != 'a' && s != 'b'){
                return false;
            }

            //Check for proper chars
            if(e != 'a' && e != 'b'){
                return false;
            }

            if (s == e)
            {
                w = w.Remove(0,1);
                w = w.Remove(w.Length - 1,1);
            }else
            {
                return false;
            }

            return inOddPalindrome(w);
        }
    }
}
