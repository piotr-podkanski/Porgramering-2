using System.Drawing;
using System.Windows.Forms;

namespace RitProgram.Classes
{
    internal class ClearCanvas : ToolBase
    {
        public ClearCanvas(Color color) : base(color, 1)
        {
        }

        public override void Draw(MouseEventArgs e, Point prevLocation, Graphics g)
        {
            // Clear the graphics context with the specified color
            g.Clear(color);
        }
    }
}
