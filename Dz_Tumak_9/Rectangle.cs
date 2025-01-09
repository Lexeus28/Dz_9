using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_Tumak_9
{
    public class Rectangle : Point
    {
        private double width;
        private double height;

        public Rectangle(double width, double height, string color, bool isVisible, int x, int y)
            : base(color, isVisible, x, y)
        {
            this.width = width;
            this.height = height;
        }
        public double Area()
        {
            return width * height;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"ширина: {width}\nдлина = {height}\nплощадь = {Area():F2}");
        }
    }
}
