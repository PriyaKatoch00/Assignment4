using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Shapes
    {
        public double l;
        //public int w;
        public double b;
        public double radius;


        public Shapes(int l)
        {
            this.l = l;
            Console.WriteLine("Area of Square: " + (l * l));
        }

        public Shapes(int l, int b)
        {
            this.l = l;
            this.b = b;
            Console.WriteLine("Area of Rectangle: " + (l * b));
        }

        public Shapes(double radius)
        {
            this.radius = radius;
            Console.WriteLine("Area of Circle: " + (3.14 * radius * radius));

        }
        public Shapes(double l, double b)
        {
            this.l = l;
            this.b = b;
            Console.WriteLine("Area of Triangle: " + (0.5 * l* b));


        }

        static void Main()
        {
            Shapes s = new Shapes(3);
            Shapes s1 = new Shapes(3, 5);
            Shapes s2 = new Shapes(5.1);
            Shapes s3 = new Shapes(5.0, 5.0);
        }
    }
}