using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotoOuter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (i + j == 5)
                        goto outer;
                    Console.Write("i=" + i + "j=" + j + " ");
                }
                Console.WriteLine();
            }
        outer:;
        }
    }
}
