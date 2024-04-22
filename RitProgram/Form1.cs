namespace RitProgram
{
    using RitProgram.Classes;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        // här deklareras alla variabl
        #region Variables
        private Bitmap canvasBitmap;
        private Graphics? canvasGraphics;
        private Point pointLocation = new Point();
        // kollar om användaren "ritar" / håller in musen på ytan
        private bool drawing = false;

        // Alla Redskap
        private Pencil? pencilTool;
        private Eraser? erasingTool;
        private Bucket? fillingTool;
        private SprayPaint? sprayTool;
        private ClearCanvas? clearTool;

        // Värde som används för att ändra hur redskapen funkar
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

        // Inisialisering av alla redskap, används för att försäkra att egenskaperna ändras vid behov
        private void InitTools(Color color, int size)
        {
            pencilTool = new Pencil(color, size);
            erasingTool = new Eraser(canvasColor, size);
            fillingTool = new Bucket(color);
            sprayTool = new SprayPaint(color, size);
            clearTool = new ClearCanvas(canvasColor);
        }
        // Inisialisering av rit ytan, för att försäkra att rit ytan skapas
        private void InitPaint()
        {
            canvasBitmap = new Bitmap(pxbCanvas.Width, pxbCanvas.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(canvasColor);
            pxbCanvas.Image = canvasBitmap;
        }

        #endregion

        // allt som har attt göra med interactionen mellan användaren och rit ytan
        #region Mouse canvas interaction

        // En metod som kallas om användaren trycker på rit ytan
        private void pxbCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            // redskapen uppdateras när användaren trycker på ytan
            InitTools(chosenColor, (int)nudSize.Value);

            // Säger till programmet att användaren vill börja rita
            drawing = true;

            // Om användaren har valt hink metoden så ska den användas direkt hen trycker på ytan
            if (chosenTool == 3)
            {
                // Uppdaterar platsen för musen sedan använder fillTool
                pointLocation= e.Location;
                fillingTool!.canvasBitmap = canvasBitmap;
                fillingTool.Use(e, pointLocation, canvasGraphics);

            }
        }

        // metod som kör igång om man rör musen över rit ytan.
        private void pxbCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            // kollar om personen har tryckt på musen för att rita 
            // kollar också om användaren försöker använda sig av hinken 
            if (drawing && chosenTool != 3)
            {
                // kör igen en metod som använder de valda redskapet
                useTool(e, pointLocation, canvasGraphics!, chosenTool);
            }
            // uppdaterar platsen och rit ytan, detta används så att ritprogrammet kan faktiskt -
            // rita på rätt plats och sedan också visa använadern vad som finns på ytan.
            pointLocation = e.Location;
            pxbCanvas.Invalidate();
        }

        // En metod som uppdateraar att användaren har slutt använda redskapet
        private void pxbCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        #endregion

        // denna delen är för hur man ska använda redskapen 
        #region Usetool

        // detta är en metod som förenklarar för  programmet vilken redskap som används och sedan använder den. 
        private void useTool(MouseEventArgs e, Point pointLocation, Graphics g, int num)
        {

            // beronde på vilken redskaps nummer metoden får använder den sig av en ett annat redskap
            switch (num)
            {
                case 1:
                    pencilTool!.Use(e, pointLocation, g);
                    break;
                case 2:
                    erasingTool!.Use(e, pointLocation, g);
                    break;
                // de går i nummer ordning 1:penna, 2:sudd, 3:Hink, 4: spray där 3 används vid klickande
                case 4:
                    sprayTool!.canvasBitmap = canvasBitmap;
                    sprayTool.Use(e, pointLocation, g);
                    break;
            }

        }
        #endregion

        // Alla  metoder används för att kunna byta mellan redskap och ändra värden olika värde  
        #region Choose tool buttons
        private void pxbPencil_Click(object sender, EventArgs e)
        {
            // ändrar alla backgrundsfärger till vit
            foreach (PictureBox btn in btnColors)
            {
                btn.BackColor = Color.White;
            }

            //Sätter sin egen färg till grå (detta ger en effekt att du har valt en knapp)
            pxbPencil.BackColor = Color.Silver;

            // Bärettar till programmet vilket redskap som är valt 
            chosenTool = 1;
            // ändrar värde på storleken för verktyget samt ser till att Storleks väljaren syns
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
            // Storlek har ingen påverka på hinken, därför göms det undan när den är vald.
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

        // ser till att när man håller in knappen att rensa, den ändrar färg för att informera användaren att de har tryck i knappen 
        private void pxbTrash_MouseDown(object sender, MouseEventArgs e)
        {
            pxbTrash.BackColor = Color.Silver;
        }

        // När användaren har lyft upp knappen så rensas ritytan 
        private void pxbTrash_MouseUp(object sender, MouseEventArgs e)
        {

            clearTool!.Use(null!, pointLocation, canvasGraphics!);
            pxbCanvas.Invalidate();
            pxbTrash.BackColor = Color.White;
        }

        // denna metoden ska kunna spara en bild med användarens ritning.
        private void pxbSave_Click(object sender, EventArgs e)
        {

        }

        #endregion

        // alla metoder för att byta färger
        #region choose color

        // denna metoden gör så att du kan alltid se vilken färg du använder 
        private void chooseColor(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                // för att undvika att använda en metod för varje knapp, vi ser till att objektet som kallar metoden - 
                // är en Picture box, sedan så skapar vi en ny objekt som kommer vara en picture bóx
                PictureBox self = (PictureBox)sender;

                // Om denna variablen är en picturebox kan man behandla den som ett och ta färvärdet 
                pxbCurrent.BackColor = self.BackColor;
                chosenColor = self.BackColor;
            }
        }

        // denna funktion finns för att kunna använda en color selector.
        private void pxbOwnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pxbCurrent.BackColor = colorDialog1.Color;
            chosenColor = colorDialog1.Color;
        }
        #endregion

        //Stänger ner aplicationen
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
