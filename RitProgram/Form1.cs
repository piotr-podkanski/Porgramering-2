namespace RitProgram
{
    using RitProgram.Classes;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        // h�r deklareras alla variabl
        #region Variables
        private Bitmap canvasBitmap;
        private Graphics? canvasGraphics;
        private Point pointLocation = new Point();
        // kollar om anv�ndaren "ritar" / h�ller in musen p� ytan
        private bool drawing = false;

        // Alla Redskap
        private Pencil? pencilTool;
        private Eraser? erasingTool;
        private Bucket? fillingTool;
        private SprayPaint? sprayTool;
        private ClearCanvas? clearTool;

        // V�rde som anv�nds f�r att �ndra hur redskapen funkar
        public Color canvasColor = Color.White;
        public Color chosenColor = Color.Black;
        public int chosenTool = 1;
        // 
        public PictureBox[] btnColors;

        #endregion 


        // allt som handlar om initsialisering av programmet
        #region Init

        // initsialisera programmet
        public Form1()
        {

            InitializeComponent();
            InitPaint();
            btnColors = new PictureBox[] { pxbPencil, pxbEraser, pxbBucket, pxbSpray };
        }

        // Inisialisering av alla redskap, anv�nds f�r att f�rs�kra att egenskaperna �ndras vid behov
        private void InitTools(Color color, int size)
        {
            pencilTool = new Pencil(color, size);
            erasingTool = new Eraser(canvasColor, size);
            fillingTool = new Bucket(color);
            sprayTool = new SprayPaint(color, size);
            clearTool = new ClearCanvas(canvasColor);
        }
        // Inisialisering av rit ytan, f�r att f�rs�kra att rit ytan skapas
        private void InitPaint()
        {
            canvasBitmap = new Bitmap(pxbCanvas.Width, pxbCanvas.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(canvasColor);
            pxbCanvas.Image = canvasBitmap;
        }

        #endregion

        // allt som har attt g�ra med interactionen mellan anv�ndaren och rit ytan
        #region Mouse canvas interaction

        // En metod som kallas om anv�ndaren trycker p� rit ytan
        private void pxbCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            // redskapen uppdateras n�r anv�ndaren trycker p� ytan
            InitTools(chosenColor, (int)nudSize.Value);

            // S�ger till programmet att anv�ndaren vill b�rja rita
            drawing = true;

            // Om anv�ndaren har valt hink metoden s� ska den anv�ndas direkt hen trycker p� ytan
            if (chosenTool == 3)
            {
                // Uppdaterar platsen f�r musen sedan anv�nder fillTool
                pointLocation= e.Location;
                fillingTool!.canvasBitmap = canvasBitmap;
                fillingTool.Use(e, pointLocation, canvasGraphics);

            }
        }

        // metod som k�r ig�ng om man r�r musen �ver rit ytan.
        private void pxbCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            // kollar om personen har tryckt p� musen f�r att rita 
            // kollar ocks� om anv�ndaren f�rs�ker anv�nda sig av hinken 
            if (drawing && chosenTool != 3)
            {
                // k�r igen en metod som anv�nder de valda redskapet
                useTool(e, pointLocation, canvasGraphics!, chosenTool);
            }
            // uppdaterar platsen och rit ytan, detta anv�nds s� att ritprogrammet kan faktiskt -
            // rita p� r�tt plats och sedan ocks� visa anv�nadern vad som finns p� ytan.
            pointLocation = e.Location;
            pxbCanvas.Invalidate();
        }

        // En metod som uppdateraar att anv�ndaren har slutt anv�nda redskapet
        private void pxbCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        #endregion

        // denna delen �r f�r hur man ska anv�nda redskapen 
        #region Usetool

        // detta �r en metod som f�renklarar f�r  programmet vilken redskap som anv�nds och sedan anv�nder den. 
        private void useTool(MouseEventArgs e, Point pointLocation, Graphics g, int num)
        {

            // beronde p� vilken redskaps nummer metoden f�r anv�nder den sig av en ett annat redskap
            switch (num)
            {
                case 1:
                    pencilTool!.Use(e, pointLocation, g);
                    break;
                case 2:
                    erasingTool!.Use(e, pointLocation, g);
                    break;
                // de g�r i nummer ordning 1:penna, 2:sudd, 3:Hink, 4: spray d�r 3 anv�nds vid klickande
                case 4:
                    sprayTool!.canvasBitmap = canvasBitmap;
                    sprayTool.Use(e, pointLocation, g);
                    break;
            }

        }
        #endregion

        // Alla  metoder anv�nds f�r att kunna byta mellan redskap och �ndra v�rden olika v�rde  
        #region Choose tool buttons
        private void pxbPencil_Click(object sender, EventArgs e)
        {
            // �ndrar alla backgrundsf�rger till vit
            foreach (PictureBox btn in btnColors)
            {
                btn.BackColor = Color.White;
            }

            //S�tter sin egen f�rg till gr� (detta ger en effekt att du har valt en knapp)
            pxbPencil.BackColor = Color.Silver;

            // B�rettar till programmet vilket redskap som �r valt 
            chosenTool = 1;
            // �ndrar v�rde p� storleken f�r verktyget samt ser till att Storleks v�ljaren syns
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
            // Storlek har ingen p�verka p� hinken, d�rf�r g�ms det undan n�r den �r vald.
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

        // ser till att n�r man h�ller in knappen att rensa, den �ndrar f�rg f�r att informera anv�ndaren att de har tryck i knappen 
        private void pxbTrash_MouseDown(object sender, MouseEventArgs e)
        {
            pxbTrash.BackColor = Color.Silver;
        }

        // N�r anv�ndaren har lyft upp knappen s� rensas ritytan 
        private void pxbTrash_MouseUp(object sender, MouseEventArgs e)
        {

            clearTool!.Use(null!, pointLocation, canvasGraphics!);
            pxbCanvas.Invalidate();
            pxbTrash.BackColor = Color.White;
        }

        // denna metoden ska kunna spara en bild med anv�ndarens ritning.
        private void pxbSave_Click(object sender, EventArgs e)
        {

        }

        #endregion

        // alla metoder f�r att byta f�rger
        #region choose color

        // denna metoden g�r s� att du kan alltid se vilken f�rg du anv�nder 
        private void chooseColor(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                // f�r att undvika att anv�nda en metod f�r varje knapp, vi ser till att objektet som kallar metoden - 
                // �r en Picture box, sedan s� skapar vi en ny objekt som kommer vara en picture b�x
                PictureBox self = (PictureBox)sender;

                // Om denna variablen �r en picturebox kan man behandla den som ett och ta f�rv�rdet 
                pxbCurrent.BackColor = self.BackColor;
                chosenColor = self.BackColor;
            }
        }

        // denna funktion finns f�r att kunna anv�nda en color selector.
        private void pxbOwnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pxbCurrent.BackColor = colorDialog1.Color;
            chosenColor = colorDialog1.Color;
        }
        #endregion

        //St�nger ner aplicationen
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
