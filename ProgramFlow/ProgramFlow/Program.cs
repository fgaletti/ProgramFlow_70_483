using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{ 
    // 48_Short_Circuiting the OR operator
    class Program
    {
        static void Main(string[] args)
        {
            bool x = false;
            
            bool result = x || GetY();
            // bool result = x | GetY(); --> call both methods, no short circuit 
        }

        public static bool GetY()
        {
            Console.WriteLine("this methos doesnt get called");
            return true;
        }
    }
}
