using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programFirst
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Hello ");
            Console.WriteLine("World!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Good day, ");
            Console.Write(name);
            Console.WriteLine("!");
        }
    }
}
