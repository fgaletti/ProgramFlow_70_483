using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{ 
    // 47_boolean_Or_Operator
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;
            int z = 6;

            bool result = x == y || y == z;

            Console.WriteLine(result);
        }
    }
}
