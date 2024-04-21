namespace RitProgram
{
    using RitProgram.Classes;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public int num = 0;
        private Bitmap canvas;
        private Graphics? canvasGraphics;
        private Bitmap? bmp;
        private Point oldPoint = new Point();
        private bool drawing = false;

        private Pencil? pencilTool;
        private Eraser? erasingTool;
        private Bucket? fillingTool;
        private SprayPaint? sprayTool;
        private ClearCanvas? clearTool;

        public Color canvasColor = Color.White;
        public int chosenTool = 1;

        public PictureBox[] btnColors;

        public Form1()
        {
            InitializeComponent();

            // Initialize btnColors array with PictureBox controls
            btnColors = new PictureBox[] { pxbPencil, pxbEraser, pxbBucket, pxbSpray };

            InitPaint();

        }


        private void InitTools(Color color, int size)
        {
            pencilTool = new Pencil(color, size);
            erasingTool = new Eraser(canvasColor, size);
            fillingTool = new Bucket(Color.Black);
            sprayTool = new SprayPaint(Color.Black, size);
            clearTool = new ClearCanvas(canvasColor);
        }

        private void InitPaint()
        {
            canvas = new Bitmap(pxbCanvas.Width, pxbCanvas.Height); // Ensure canvas is initialized
            canvasGraphics = Graphics.FromImage(canvas);
            canvasGraphics.Clear(canvasColor);
            pxbCanvas.Image = canvas;
        }

        #region Mouse canvas interaction
        private void pxbCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing && chosenTool != 3)
            {
                useTool(e, oldPoint, canvasGraphics!, chosenTool);
            }
            oldPoint = e.Location;
            pxbCanvas.Invalidate();
        }

        private void pxbCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            InitTools(Color.Black, (int)nudSize.Value);

            drawing = true;
            oldPoint = e.Location;

            if (chosenTool == 3)
            {
                fillingTool!.canvasBitmap = canvas;
                fillingTool.Draw(e, oldPoint, canvasGraphics);

            }

        }

        private void pxbCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }
        #endregion

        private void useTool(MouseEventArgs e, Point oldpoint, Graphics g, int num)
        {



            switch (num)
            {
                case 1:
                    pencilTool!.Draw(e, oldPoint, g);
                    break;
                case 2:
                    erasingTool!.Draw(e, oldPoint, g);
                    break;
                case 4:
                    sprayTool!.canvasBitmap = canvas;
                    sprayTool.Draw(e, oldPoint, g);
                    break;


            }

        }



        private void pxbPencil_Click(object sender, EventArgs e)
        {
            foreach (PictureBox btn in btnColors)
            {

                btn.BackColor = Color.White;
            }
            pxbPencil.BackColor = Color.Silver;
            chosenTool = 1;
            nudSize.Value = 4;
            nudSize.Visible = true;
        }

        private void pxbEraser_Click(object sender, EventArgs e)
        {
            foreach (PictureBox btn in btnColors)
            {

                btn.BackColor = Color.White;
            }
            pxbEraser.BackColor = Color.Silver;
            chosenTool = 2;
            nudSize.Value = 10;
            nudSize.Visible = true;
        }

        private void pxbBucket_Click(object sender, EventArgs e)
        {
            foreach (PictureBox btn in btnColors)
            {

                btn.BackColor = Color.White;
            }
            pxbBucket.BackColor = Color.Silver;
            chosenTool = 3;
            nudSize.Visible = false;

        }

        private void pxbSpray_Click(object sender, EventArgs e)
        {
            foreach (PictureBox btn in btnColors)
            {
                btn.BackColor = Color.White;
            }
            pxbSpray.BackColor = Color.Silver;
            chosenTool = 4;
            nudSize.Value = 20;
            nudSize.Visible = true;
        }


        private void pxbTrash_MouseDown(object sender, MouseEventArgs e)
        {
            pxbTrash.BackColor = Color.Silver;
        }

        private void pxbTrash_MouseUp(object sender, MouseEventArgs e)
        {
            // Call the clearTool.Draw method without using the event arguments and point
            clearTool!.Draw(null!, oldPoint, canvasGraphics!);
            pxbCanvas.Invalidate();
            pxbTrash.BackColor = Color.White;
        }
    }
}
