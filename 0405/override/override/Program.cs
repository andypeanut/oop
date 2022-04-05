using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @override
{
    class P
    {


        public void Parent()
        {
            Console.WriteLine("부모 ");
        }
    }

    class C : P
    {
        public void Child()
        {

            Console.WriteLine("자식");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            C print = new C();
            print.Parent();
            print.Child();
        }
    }
}