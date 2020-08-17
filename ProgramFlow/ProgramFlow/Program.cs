using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{ 
    // 46 Using the equality operator
    class Program
    {
        static void Main(string[] args)
        {
            int x = 42;
            int y = 1;
            int z = 42;

            bool a = x < y;
            bool b = x == z;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
