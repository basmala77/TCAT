using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCat4
{
    internal class Program
    {
        delegate int My(int x, int y);
        static void Main(string[] args)
        {
            var t = new Task();
            My deleget;
            deleget = t.Add;
            Console.WriteLine("Addition result: " + deleget(10, 5));

            deleget += t.Sub;
            Console.WriteLine("Subtraction result: " + deleget(10, 5));

            deleget += t.Mul;
            Console.WriteLine("Multiplication result: " + deleget(10, 5));

            deleget += t.Div;
            Console.WriteLine("Division result: " + deleget(10, 5));

            Console.ReadKey();
        }
    }
    class Task
    {
        public int Add(int x, int y) => x + y;
        public int Sub(int x, int y) => x - y;
        public int Mul(int x, int y) => x * y; 
        public int Div(int x, int y)
        {
            if (y != 0)
                return x / y;
            return 0;
        }

    }
}
