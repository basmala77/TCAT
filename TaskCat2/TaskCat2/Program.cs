using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(5, 10);
            Rectangle rectangle2 = new Rectangle(3, 6);

            Console.WriteLine($"Perimeter of Rectangle1: {rectangle1.CalcPerimeter()}");
            Console.WriteLine($"Area of Rectangle1: {rectangle1.CalcArea()}");
            Console.WriteLine($"Perimeter of Rectangle2: {rectangle2.CalcPerimeter()}");
            Console.WriteLine($"Area of Rectangle2: {rectangle2.CalcArea()}");
            Console.ReadLine();

        }
    }
    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }
        public double CalcArea()
        { return Length * Width; }
        public double CalcPerimeter()
        { return 2 * (Length + Width); }

    }

}
