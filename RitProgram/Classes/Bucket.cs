using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RitProgram.Classes
{
    internal class Bucket : ToolBase
    {
        public Bitmap canvasBitmap;

        public Bucket(Color color) : base(color, 1)
        {
        }

        public override void Draw(MouseEventArgs e, Point prevLocation, Graphics g)
        {
            if (canvasBitmap == null) return;

            // Get the color of the pixel at the mouse location on the Bitmap
            Color targetColor = GetPixelColor(e.Location, canvasBitmap);

            // Create a dictionary to track visited pixels during flood fill
            Dictionary<Point, bool> visited = new Dictionary<Point, bool>();

            // Perform flood fill operation
            FloodFill(e.Location, targetColor, Color, canvasBitmap);

            // Draw the updated Bitmap onto the Graphics object
            g.DrawImage(canvasBitmap, Point.Empty);
        }


        private Color GetPixelColor(Point location, Bitmap canvas)
        {
            // Check if the location is within the bounds of the canvas
            if (location.X < 0 || location.X >= canvas.Width || location.Y < 0 || location.Y >= canvas.Height)
            {
                // If the location is outside the canvas bounds, return a default color (black)
                return Color.Black;
            }

            // Retrieve the color of the pixel from the canvas bitmap
            return canvas.GetPixel(location.X, location.Y);
        }

        private const int MaxRecursionDepth = 1000;

        private void FloodFill(Point startPoint, Color targetColor, Color fillColor, Bitmap canvas)
        {
            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(startPoint);

            while (queue.Count > 0)
            {
                Point currentPoint = queue.Dequeue();

                // Check if the current point is within the canvas bounds
                if (IsWithinCanvasBounds(currentPoint, canvas.Size))
                {
                    // Check if the current point has the target color
                    if (canvas.GetPixel(currentPoint.X, currentPoint.Y) == targetColor)
                    {
                        // Fill the current point with the fill color
                        canvas.SetPixel(currentPoint.X, currentPoint.Y, fillColor);

                        // Enqueue neighboring points for processing
                        queue.Enqueue(new Point(currentPoint.X + 1, currentPoint.Y));
                        queue.Enqueue(new Point(currentPoint.X - 1, currentPoint.Y));
                        queue.Enqueue(new Point(currentPoint.X, currentPoint.Y + 1));
                        queue.Enqueue(new Point(currentPoint.X, currentPoint.Y - 1));
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
