using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RoboTracker
{
    class Path
    {
        // Feilds
        private Graphics graphics;
        private Pen pen;
        private List<Point> points;
        private bool isDrawing;


        public Path(Graphics graphics, Pen pen)
        {
            // Initilizing feilds 

            this.graphics = graphics;
            this.pen = pen;

            points = new List<Point>();
            isDrawing = false;
        }
        public void StartPath(Point mousePosition)
        {
            // Clears previously loged points and starts tracking new mouse movements
            points.Clear();
            points.Add(mousePosition);
            isDrawing = true;
        }
        public void DrawPath(Point mousePosition)
        {
            // Draws a line where the cursor is
            if (isDrawing == true)
            {
                points.Add(mousePosition);
                int pathCount = points.Count - 1; // converting to zero based
                graphics.DrawLine(pen, points[pathCount - 1], points[pathCount]);
            }
        }
        public void StopPath()
        {
            // Disables drawing
            isDrawing = false;
        }
        public List<Point> Points { get => points; set => points = value; }

    }
}
