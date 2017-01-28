using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPlus
{
    class ABPlus
    {
        static int Main(string[] args)
        {
            if (args[0] == null)
            {
                Console.WriteLine("Please enter a string of a's, b's and use +'s.");
                return 1;
            }
            string s = args[0];
            //Words a and b are in ABPlus.
            // If v and w are words in ABPlus, then so are vw and v+w.

            var a = new ABPlus();
            bool result = a.inABPlus(s, false);
            Console.WriteLine("String = {0} Member?  {1}", s, result);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            return 0;
        }

        public bool inABPlus(string w, bool plusAble)
        {
            // If string is length of 0 we're done
            if (w.Length == 0)
            {
                return true;
            }
            else if (plusAble == false && w[0] == '+') // Do not allow a plus to follow another
            {
                return false;
            }
            else if (w[0] != 'a' && w[0] != 'b' && w[0] != '+') // Do not allow anything other than a, b or +
            {
                return false;
            }
            else if (w.Length == 1 && w[0] == '+') // Do not allow a + to be the last char
                return false;

            if(w[0] == 'a' || w[0] == 'b') // Mark the option to use another +
            {
                plusAble = true;
            }

            if (w[0] == '+') // We used a plus, now mark it unable the next iteration
                plusAble = false;

            w = w.Remove(0, 1); // Send in the rest of the string

            return inABPlus(w, plusAble);
        }
    }
}
