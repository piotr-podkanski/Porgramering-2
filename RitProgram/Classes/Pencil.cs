using RitProgram.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

// Denna class ärver metoder och variabler från ToolBase
internal class Pencil : ToolBase
{
    public Pencil(Color setColor, int setSize) : base(setColor, setSize)
    {
        InitPen();
    }

    private void InitPen()
    {
        // gör pennan rund
        pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round,
            System.Drawing.Drawing2D.LineCap.Round,
            System.Drawing.Drawing2D.DashCap.Round);
    }

    //Använder sig av metoden från de ärvande klassen override tillåter att ändra vad funktionen gör
    public override void Use(MouseEventArgs e, Point prevLocation, Graphics g)
    {
        if (g == null)
            throw new ArgumentNullException(nameof(g));
        
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        g.DrawLine(pen, prevLocation, e.Location);
    }
}

