using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    // goto 
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            if (x == 3)
            {
                goto customlabel;
            }
            x++;

            customlabel:
            Console.WriteLine(x);
        }

    }
}
