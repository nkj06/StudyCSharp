﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }
        public void publicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }
        public abstract void AbstractMethodA();
    }
    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.publicMethodA();
        }
    }
}
