using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    // 64_basic loop
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5 };

            foreach(int val in values)
            {
                Console.WriteLine(val);
            }

        }

    }
}
