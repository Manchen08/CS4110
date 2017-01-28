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
            bool result = a.inContainsABA(s);
            Console.WriteLine("String = {0} Member?  {1}", s, result);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            return 0;
        }

        public bool inContainsABA(string w)
        {
            for (int i = 0; i < w.Length; i++)
            {
                
            }
        }
    }
}
