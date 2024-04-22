using RitProgram.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

internal class Eraser : ToolBase
{
    public Eraser(Color setColor, int setSize) : base(setColor, setSize)
    {
        InitEraser();
    }
    private void InitEraser()
    {
        pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round,
            System.Drawing.Drawing2D.LineCap.Round,
            System.Drawing.Drawing2D.DashCap.Round);
    }

    public override void Use(MouseEventArgs e, Point prevLocation, Graphics g)
    {
        if (g == null)
            throw new ArgumentNullException(nameof(g));

        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        g.DrawLine(pen, prevLocation, e.Location);
    }
}

