using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class5
    {
        public static void Main1()
        {
          
            Console.WriteLine("enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = b;
            b = a;
            a = temp;
            Console.WriteLine("After swapping");
            Console.WriteLine("First Number:" + a);
            Console.WriteLine("Second Number:" + b);
            Console.ReadKey();
        }
    }
}
