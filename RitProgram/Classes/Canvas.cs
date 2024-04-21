using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RitProgram.Classes
{
    internal abstract class Canvas
    {
        //Sätter fält för klassen 
        private Color Colour;
        private int Size;
        private Pen Pen;

        // Protected används så att bara ärvande klasser kan använda sig av pen
        protected Pen pen 
        {
            get { return Pen; }
            set { Pen = value; }
        }

        public Color colour
        {
            get { return Colour; }
            set 
            { 
                Colour = value;
                pen.Color = value;
            }
        }

        public int size
        {
            get { return Size; }
            set 
            { 
                Size = value;
                pen.Width = value;
            }
        }
        
        public Canvas(Color color, int size)
        {
            this.colour = color; 
            this.size = size;
            pen = new Pen(color,size);
        }

        public abstract void Draw(MouseEventArgs e, Point prevLocation, Graphics g);

    }
}
