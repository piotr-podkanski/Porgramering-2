using System;
using System.Drawing;
using System.Windows.Forms;

namespace RitProgram.Classes
{
    internal class SprayPaint : ToolBase
    {
        // likt bucket denna class använder sig av en bitmap från rit ytan
        public Bitmap canvasBitmap;

        public SprayPaint(Color setColor,int setSize) : base(setColor, setSize) {}

        public override void Use(MouseEventArgs e, Point prevLocation, Graphics g)
        {

            // använder spray metoden för att bestämma vart den ská rita
            Spray(e.Location, setColor, canvasBitmap);

            // ritar ut alla punkter från spray metoden 
            g.DrawImage(canvasBitmap, Point.Empty);
        }

        private void Spray(Point sprayPoint, Color color, Bitmap canvas)
        {
      
            Random random = new Random();
            
            // Slappar en area beroende på setSize, sedan loopar genom varjepixel för
            for (int x = sprayPoint.X - setSize; x <= sprayPoint.X + setSize; x++)
            {
                for (int y = sprayPoint.Y - setSize; y <= sprayPoint.Y + setSize; y++)
                {
                    // För att simulera  spray effekten, programmet slumpmässigt väler punkter
                    int sprayX = x + random.Next(-setSize, setSize);
                    int sprayY = y + random.Next(-setSize, setSize);

                    // Kollar om pixlarna är inom ritytan
                    if (IsWithinCanvasBounds(new Point(sprayX, sprayY), canvas.Size))
                    {
                        // Färgar pixeln
                        canvas.SetPixel(sprayX, sprayY, color);
                    }
                }
            }
        }
            
            private bool IsWithinCanvasBounds(Point point, Size canvasSize)
        {
            return point.X >= 0 && point.X < canvasSize.Width &&
                   point.Y >= 0 && point.Y < canvasSize.Height;
        }
    }
}
