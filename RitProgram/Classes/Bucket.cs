using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RitProgram.Classes
{
    internal class Bucket : ToolBase
    {
        // Fill funktionen använder sig av en bitmap, den bitmappen kommer vara samma bitmap som påm ritytan, denm får deklareras innan användning
        public Bitmap canvasBitmap; 
                                   
        public Bucket(Color setColor) : base(setColor, 1) { }

        // vad som sker när redskapet används
        public override void Use(MouseEventArgs e, Point Location, Graphics g)
        {
            // bestemmer vilken färg som ska bli förändrat
            Color targetColor = GetPixelColor(e.Location, canvasBitmap);

            // Bestemmer vilka pixlar som ska fyllas
            FloodFill(e.Location, targetColor, setColor, canvasBitmap);

            // Fyller i sädda pixlar
            g.DrawImage(canvasBitmap, Point.Empty);
        }

        // Denna funktionen hämtar vilken pixel som användaren klickar på
        private Color GetPixelColor(Point location, Bitmap canvasBitmap)
        {
            // Hämtar den färgen som trycks på
            return canvasBitmap.GetPixel(location.X, location.Y);
        }

        // bestämmer vilka pixlar som ska fyllas
        private void FloodFill(Point startPoint, Color targetColor, Color setColor, Bitmap canvasBitmap)
        {
            // Queue í enkalre ord är en array av element som sparas i FIFO formatet och skapar en kö
            // FIFO är betyder first in first out som betyder att om ett element läggs till "KÖN" så kommer den också komma ut först
            Queue<Point> queue = new Queue<Point>();
            // Den lägger in de första punkten i kön
            queue.Enqueue(startPoint); 

            while (queue.Count > 0)
            {
                // tar bort den första pixeln från kön
                Point currentPoint = queue.Dequeue();
                

                // Ser till att pixeln finn med i bitmappen, om den inte finns så struntar den i pixelns/ punkten
                if (IsWithinCanvasBounds(currentPoint, canvasBitmap.Size))
                {
                    // Kollar så om färgen på pixeln är samma som man vill byta så att bara en typ av färg faktist ändras
                    if (canvasBitmap.GetPixel(currentPoint.X, currentPoint.Y) == targetColor)
                    {
                        // Bestämmer att denna punkten ska 
                        canvasBitmap.SetPixel(currentPoint.X, currentPoint.Y, setColor);

                        // ¨Lägger till granpixlarna till kön för att de ska kollas om de ska fyllas in eller ej
                        queue.Enqueue(new Point(currentPoint.X + 1, currentPoint.Y));
                        queue.Enqueue(new Point(currentPoint.X - 1, currentPoint.Y));
                        queue.Enqueue(new Point(currentPoint.X, currentPoint.Y + 1));
                        queue.Enqueue(new Point(currentPoint.X, currentPoint.Y - 1));
                    }
                }
            }
        }
       
        // används för att kolla om en pixel är på rit ytan.
        private bool IsWithinCanvasBounds(Point point, Size canvasSize)
        {
            return point.X >= 0 && point.X < canvasSize.Width &&
                   point.Y >= 0 && point.Y < canvasSize.Height;
        }
    }
}
