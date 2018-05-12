using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    abstract class Figure
    {
        public abstract double calcSquare();
        public abstract double calcPerim();
    }

    class Triangle : Figure
    {
        private double x1;
        private double x2;
        private double x3;

        public Triangle(double x1, double x2, double x3)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
        }

        public override double calcPerim()
        {
            return x1 + x2 + x3;
        }
        
        public override double calcSquare()
        {
            double p = (x1 + x2 + x3) / 2;
            return Math.Sqrt(p * (p - x1) * (p - x2) * (p - x3));
        }
    }

    class Rectangle : Figure
    {
        private double x1;
        private double x2;

        public Rectangle(double x1, double x2)
        {
            this.x1 = x1;
            this.x2 = x2;
        }
        
        public override double calcPerim()
        {
            return (x1 * 2) + (x2 * 2);
        }

        public override double calcSquare()
        {
            return x1 * x2;
        }
    }

    class TestFigureClass
    {
        public static void printFigure(Figure figure)
        {
            Console.WriteLine("Perimeter = " + figure.calcPerim() + " , Square = " + figure.calcSquare());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(20, 35, 20);
            TestFigureClass.printFigure(triangle);

            Rectangle rectangle = new Rectangle(25, 10);
            TestFigureClass.printFigure(rectangle);

            Console.ReadKey();
        }
    }
}