using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_Tumak_9
{
    public class Circle : Point
    {
        private double radius { get; set; }
        public Circle(double radius, string color, bool isVisible, int x, int y) : base(color, isVisible, x, y)
        {
            this.radius = radius;
        }
        public double Area()
        {
            return Math.PI * radius * radius;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"радиус: {radius}\nплощадь: {Area():F2}");
        }
    }
}
