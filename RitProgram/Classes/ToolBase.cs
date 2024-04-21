using System;
using System.Drawing;
using System.Windows.Forms;

namespace RitProgram.Classes
{
    internal abstract class ToolBase
    {
        protected Color color;
        protected int size;
        protected Pen pen;

        public Pen Pen
        {
            get { return pen; }
            set { pen = value; }
        }
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public ToolBase(Color color, int size)
        {
            this.color = color;
            this.size = size;
            pen = new Pen(color, size);
            
        }

        public abstract void Draw(MouseEventArgs e, Point prevLocation, Graphics g);
    }
}

 