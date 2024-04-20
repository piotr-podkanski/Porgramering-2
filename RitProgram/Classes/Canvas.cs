using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitProgram.Classes
{
    internal abstract class Canvas
    {
        public Color color;
        public int size;

        public Pen pen;

        public Canvas(Color color, int size)
        {
            this.color = color; 
            this.size = size;
            pen = new Pen(color,size);
        }

        public abstract void Draw(MouseEventArgs e, Point prevLocation, Graphics g);

    }
}
