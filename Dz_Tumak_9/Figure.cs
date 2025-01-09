using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_Tumak_9
{
    public abstract class Figure : IMovement
    {
        internal string colour;
        internal bool isVisible;
        public Figure (string colour, bool isVisible)
        {
            this.colour = colour;
            this.isVisible = isVisible;
        }
        public abstract void MoveHorizontally(int x);
        public abstract void MoveVertically(int y);

        public void ChangeColour (string colour)
        {
            this.colour = colour;
        }
        public void ChangeVisibility(bool isVisible)
        {
            this.isVisible=isVisible;
        }
        public virtual void Display()
        {
            Console.WriteLine($"цвет: {colour}\nвидимость: {isVisible}");
        }
    }
}
