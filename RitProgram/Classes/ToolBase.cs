using System;
using System.Drawing;
using System.Windows.Forms;

namespace RitProgram.Classes
{
    internal abstract class ToolBase
    {
        // pretected variabler så att bara classen och ärvande klasser har tillgång till dem
        protected Color setColor;
        protected int setSize;
        protected Pen pen;

        public ToolBase(Color color, int size)
        {
            this.setColor = color;
            this.setSize = size;
            pen = new Pen(color, size);
        }

        // deffinition av en funktion för alla redskap
        public abstract void Use(MouseEventArgs e, Point prevLocation, Graphics g);
    }
}

 