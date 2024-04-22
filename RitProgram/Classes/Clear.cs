using System.Drawing;
using System.Windows.Forms;

namespace RitProgram.Classes
{
    internal class ClearCanvas : ToolBase
    {
        public ClearCanvas(Color setColor) : base(setColor, 1){}

        public override void Use(MouseEventArgs e, Point prevLocation, Graphics g)
        {
            // tömmer rit ytan genomn att sätta hela ytan till vit
            g.Clear(setColor);
        }
    }
}
