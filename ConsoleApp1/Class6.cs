using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class6
    {
        public static void Main1()
        {
            Console.WriteLine("enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}x{1}x{2}={3}",a,b,c,a*b*c);
            Console.ReadKey();
        }
    }
}
