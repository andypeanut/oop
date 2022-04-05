using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingApp
{
    class MethodOverloading
    {
        public void SomeThing()
        {
            Console.WriteLine("SomeThing() is called.");
        }
        public void SomeThing(int i)
        {
            Console.WriteLine("SomeThing(int) is called.");
        }
        public void SomeThing(int i, int j)
        {
            Console.WriteLine("SomeThing(int,int) is called.");
        }
        public void SomeThing(double d)
        {
            Console.WriteLine("SomeThing(double) is called.");
        }
        public void SomeThing(int i, double d)
        {
            Console.WriteLine("SomeThing(int, double) is called.");
        }
        public void SomeThing(double d, int i)
        {
            Console.WriteLine("SomeThing(double, int) is called.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MethodOverloading obj = new MethodOverloading();
            obj.SomeThing();
            obj.SomeThing(526);
            obj.SomeThing(54, 526);
            obj.SomeThing(5.26);
            obj.SomeThing(1, 2.0);
            obj.SomeThing(1.0, 2);
        }
    }
}
