using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_Tumak_9
{
    public class Point : Figure
    {
        private int x { get; set; }
        private int y { get; set; }

        public Point(string color, bool isVisible, int x, int y) : base(color, isVisible)
        {
            this.x = x;
            this.y= y;
        }
        public override void MoveHorizontally(int x)
        {
            this.x += x;
        }
        public override void MoveVertically(int y)
        {
            this.y += y;
        }
        public override void Display()
        {
            Console.WriteLine($"цвет: {colour}\nвидимость: {isVisible}\nx: {x}\ny: {y}");
        }
    }
}
