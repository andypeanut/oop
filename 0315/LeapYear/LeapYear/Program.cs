using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("년도 입력: ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("윤년");
            }
            else
            {
                Console.WriteLine("평년");
            }
        }
    }
}
