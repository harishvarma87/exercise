using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class3
    {
        public int DivNum(int a, int b)
        {
            return (a / b);
        }

        public static void Main3()
        {
            int a = 10;
            int b = 5;
            Class3 C = new Class3();
            int c = C.DivNum(a, b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
