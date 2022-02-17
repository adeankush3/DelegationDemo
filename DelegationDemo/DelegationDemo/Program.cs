using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            System.Console.WriteLine("Welcome to Delegates Demo!!!\n Enter number to Choose Operation:\n" +
            "1. Single Cast Delegates\n" +
            "2. Multi Cast Delegate\n" +
            "3. Exit");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    SingleCastDelegation singleCastDelegation = new SingleCastDelegation();
                    singleCastDelegation.Delegates();
                    break;
               
                case 2:
                    MultiCastDelegation multicastDelegate = new MultiCastDelegation();
                    multicastDelegate.DelegatesMul();
                    break;
                
               
                default:
                    System.Console.WriteLine("Choose valid option..");
                    break;
            }
        }
    }
}
