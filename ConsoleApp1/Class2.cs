using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        public int AddNum(int a, int b)
        {
            return (a + b);
        }

        public static void Main2()
        {
            int a = 4;
            int b = 5;
            Class2 C = new Class2();
            int c = C.AddNum(a, b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
