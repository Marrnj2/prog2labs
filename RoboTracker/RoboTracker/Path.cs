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
        private Graphics graphics;
        private Pen pen;
        private List<Point> points;
        private bool isDrawing;


        public Path(Graphics graphics, Pen pen)
        {
            this.graphics = graphics;
            this.pen = pen;

            points = new List<Point>();
            isDrawing = false;
        }
        public void StartPath(Point mousePosition)
        {
            points.Clear();
            points.Add(mousePosition);
            isDrawing = true;
        }
        public void DrawPath(Point mousePosition)
        {
            if (isDrawing == true)
            {
                points.Add(mousePosition);
                int pathCount = points.Count - 1; // converting to zero based
                graphics.DrawLine(pen, points[pathCount - 1], points[pathCount]);
            }
        }
        public void StopPath()
        {
            isDrawing = false;
        }
        public List<Point> Points { get => points; set => points = value; }

    }
}
