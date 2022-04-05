﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCallApp
{
    delegate void DelegateOne(); // delegate with no params
    delegate void DelegateTwo(int i); // delegate with 1 param
    class DelegateClass
    {
        public void MethodA()
        {
            Console.WriteLine("In the DelegateClass.MethodA ...");
        }
        public void MethodB(int i)
        {
            Console.WriteLine("DelegateClass.MethodB, i = " + i);
        }
    }
    class DelegateClass2
    {
        public void MethodC()
        {
            Console.WriteLine("In the DelegateClass.MethodA ...");
        }
        public void MethodD(int i)
        {
            Console.WriteLine("DelegateClass.MethodB, i = " + i);
        }
    }
    class Program
    {
        public static void Main()
        {
            DelegateClass obj = new DelegateClass();
            DelegateClass2 obj1 = new DelegateClass2();
            DelegateOne d1 = new DelegateOne(obj.MethodA);
            DelegateTwo d2 = new DelegateTwo(obj.MethodB);
            d1(); // invoke MethodA() in DelegateClass
            d2(10); // invoke MethodB(10) in DelegateClass
            d1 = new DelegateOne(obj.MethodA);
            d1();
        }
    }
}

