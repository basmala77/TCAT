using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TaskCat3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape rec = new Rectanglee(5, 10);
            Shape cir = new Circle(5);

            Console.WriteLine("Area of Rectangle: " + rec.CalculateArea());
            Console.WriteLine("Area of Circle: " + cir.CalculateArea());
            Console.ReadLine();
        }
    }
    abstract class Shape
    {
        public abstract double CalculateArea();
    }
    class Rectanglee : Shape
    {
        public double Length;
        public double Width;
        public Rectanglee(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }
        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

}
