using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class7
    {
        public static void Main1()
        {
            Console.WriteLine("Input the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            Console.WriteLine("{0} mod {1}={2}", a, b, a % b);
            Console.ReadKey();
        }
    }
}
