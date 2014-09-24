using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_aa223gg_1_2_ritamedasterisker
{
    class Program
    {
        static void Main(string[] args)
        {
        for (int row = 1; row <= 25; row++)
            {
                switch (row % 3)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                }
                if (row % 2 == 0)
                {
                    Console.Write(" ");
                }

                for (int col = 1; col <= 39; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

