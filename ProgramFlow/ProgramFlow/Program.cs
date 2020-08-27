using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    // 62_switch_statement
    class Program
    {
        static void Main(string[] args)
        {
            int x = 15;

            switch(x)
            {
                case 13:
                case 14:
                    {
                        Console.WriteLine("value is 14  ");
                        goto case 15;
                    }
                case 15:
                    {
                        Console.WriteLine("value is 15  ");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("DEfault");
                        break;
                    }
            }

        }

    }
}
