using System;
using System.Drawing;
using System.Windows.Forms;

namespace RitProgram.Classes
{
    internal class SprayPaint : ToolBase
    {
        public Bitmap canvasBitmap;

        public SprayPaint(Color color,int size) : base(color, size)
        {

        }

        public override void Draw(MouseEventArgs e, Point prevLocation, Graphics g)
        {
            if (canvasBitmap == null) return;

            // Get the spray point from the current mouse location
            Point sprayPoint = e.Location;

            // Perform spraying
            Spray(sprayPoint, Color, canvasBitmap);

            // Draw the updated Bitmap onto the Graphics object
            g.DrawImage(canvasBitmap, Point.Empty);
        }

        private void Spray(Point sprayPoint, Color color, Bitmap canvas)
        {
            // Create a random number generator
            Random random = new Random();

            // Calculate the spray area based on the size of the spray tool
            int sprayArea = size * 2; // Double the size for radius

            // Loop through each pixel in a square region around the spray point
            for (int x = sprayPoint.X - sprayArea; x <= sprayPoint.X + sprayArea; x++)
            {
                for (int y = sprayPoint.Y - sprayArea; y <= sprayPoint.Y + sprayArea; y++)
                {
                    // Add some randomness to the position to simulate spray effect
                    int sprayX = x + random.Next(-size, size);
                    int sprayY = y + random.Next(-size, size);

                    // Check if the adjusted position is within the canvas bounds
                    if (IsWithinCanvasBounds(new Point(sprayX, sprayY), canvas.Size))
                    {
                        // Set the pixel color to the spray color
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
