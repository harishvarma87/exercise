using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class9
    {
        public static float Avg(int a, int b, int c, int d)
        {
            int sum = a + b + c + d;
            return sum / 4;
        }

        public static void Main1()
        {
            Console.WriteLine("Input the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the fourth number");
            int d = Convert.ToInt32(Console.ReadLine());
            float res = Avg(a, b, c, d);
            Console.Write("The average of {0} , {1} , {2} , {3} is: {4}",a,b,c,d,res);
            Console.ReadKey();

        }
    }
}
