using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationDemo
{
    public delegate int operation(int x, int y);
    public class Program
    {
        static int Addition(int x,int y)
        {
            return x + y;   
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Delection program");

            Console.WriteLine("Delegation POC!");
            operation obj=new operation(Addition);
            Console.WriteLine("Addition is {0}", obj(17, 33));
            Console.WriteLine();
        }
    }
}
