using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumAvg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            sumAvg(a);
        }
        static void sumAvg(int[] abc)
        {
            int sum = 0;
            int avg = 0;

            for(int i = 0; i <= abc.Length; i++)
            {
                sum += i;
            }
            avg = sum / abc.Length;
            Console.WriteLine(sum);
            Console.WriteLine(avg);

        }
    }
}
