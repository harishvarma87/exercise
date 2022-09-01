using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class8
    {
        public static void Main1()
        {
            Console.WriteLine("Input the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<11;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, i, a * i);
            }
            Console.ReadKey();
        }
    }
}
