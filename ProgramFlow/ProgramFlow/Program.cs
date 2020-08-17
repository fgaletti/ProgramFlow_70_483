using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    // 49_50_And_Operator
    class Program
    {
        static void Main(string[] args)
        {
           // int value = 42;
           // bool result = (value > 0) && (value < 100); // 

          //  Console.WriteLine(result); // --> call both methods, no short circuit

            string input = null;
            bool result = (input != null) && GetY();
            //  input != null = false, so GetY() wont get called
        }

        public static bool GetY()
        {
            Console.WriteLine("OUTPUT");
            return true;
        }
    }
}
