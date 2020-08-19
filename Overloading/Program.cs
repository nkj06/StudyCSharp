﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static int Plus(int a, int b)
        {
            return a + b;
        }
        static int Plus(int a, int b, int c)
        {
            return a + b + c;
        }
        static float Plus(float a, float b, float c)
        {
            return a + b + c;
        }
        static float Plus(float a, float b)
        {
            return a + b;
        }
        static double Plus(double a, double b, double c)
        {
            return a + b + c;
        }
        static double Plus(double a, double b)
        {
            return a + b;
        }
        static int Sum(params int[] args)
        {
            int result = 0;
            foreach (var item in args)
            {
                result += item;
            }
            return result;
        }
        static void MyMethod(string arg1 = "", string arg2 = "")
        {
            Console.WriteLine("MyMethod A");
        }
        static void MyMethod()
        {
            Console.WriteLine("MyMethod B");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Plus(3.14f, 2.56f));
            //Console.WriteLine(Plus(3.14, 5.6));
            //int sum = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            //Console.WriteLine($"sum = {sum}");

            MyMethod("are", "you");
            MyMethod();
        }
    }
}
