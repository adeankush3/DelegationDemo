using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationDemo
{
    public class Operation
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addtion of a+b = " + (a + b));
        }
        public static void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication of a*b  = " + (a * b));
        }
    }
}
