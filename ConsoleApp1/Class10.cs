using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class10
    {
        public static void Main1()
        {
            Console.WriteLine("Input the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y).z is {3} and x.y + y.z is {4}",a,b,c,(a+b)*c,a*b+b*c);
            Console.ReadKey();
        }
    }
}
