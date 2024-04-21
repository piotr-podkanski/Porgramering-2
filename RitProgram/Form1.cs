namespace RitProgram
{
    using RitProgram.Classes;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;


    public partial class Form1 : Form
    {

        private Bitmap canvas = new Bitmap(800, 600); // Initialize canvas directly
        private Graphics? canvasGraphics;
        
        private Point oldPoint = new Point();
        private bool drawing = false;
        private Pencil pencil;

        public Form1()
        {

            InitializeComponent();   
            pencil = new Pencil(Color.Black, 5);
            initPaint();

        }
        private void initPaint()
        {
            canvas = new Bitmap(pxbCanvas.Width, pxbCanvas.Height); // Ensure canvas is initialized
            canvasGraphics = Graphics.FromImage(canvas);
            canvasGraphics.Clear(Color.White);
            pxbCanvas.Image = canvas;
        }
        #region Mouse canvas interaction
        private void pxbCanvas_MouseMove(object sender, MouseEventArgs e)

        {

            if (drawing)
            {
                pencil.Draw(e, oldPoint, canvasGraphics!); // Use pencil.Draw method
                oldPoint = e.Location;
                pxbCanvas.Invalidate();
            }
        }
        private void pxbCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            
            drawing = true;
            oldPoint = e.Location;
        }
        private void pxbCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        #endregion
    }
}