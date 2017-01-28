using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsABA
{
    class ContainsABA
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
            var a = new ContainsABA();
            bool result = a.inContainsABA(s, 0);
            Console.WriteLine("String = {0} Member?  {1}", s, result);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            return 0;
        }

        public bool inContainsABA(string w, int place)
        {
            // Can't contain ABA if it's less than 3.
            if (w.Length == 0)
                return false;

            switch (place) // Check where we are in the check for aba
            {
                case 0:
                    if (w[0] == 'a')
                        place = 1;
                    break;

                case 1:
                    if (w[0] == 'b')
                        place = 2;
                    else if (w[0] == 'a')
                        place = 1;
                    else
                        place = 0;
                    break;

                case 2:
                    if (w[0] == 'a')
                    {
                        for (int i = 0; i < w.Length -1; i++)
                        {
                            if(w[i] != 'a' && w[i] != 'b')
                            {
                                return false;
                            }

                        }
                        return true;
                    }
                    else
                        place = 0;
                    break;
            }

            if (w[0] != 'a' && w[0] != 'b') // Only allow a or b
                return false;

            w = w.Remove(0, 1);

            return inContainsABA(w, place);
        }
    }
}
