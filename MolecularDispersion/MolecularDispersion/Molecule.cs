using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MolecularDispersion
{
    class Molecule
    {
        private const int SIZE = 10;

        private Point position;
        private Brush brush;
        private Random random;
        private Graphics graphics;
        public Molecule(Point position, Color color, Random random, Graphics graphics)
        {
            this.random = random;
            this.graphics = graphics;
            this.position = position;
            brush = new SolidBrush(color);
        }
        public void Move()
        {
            position.X += random.Next(-SIZE, SIZE);
            position.Y += random.Next(-SIZE, SIZE);


        }
        public void Draw()
        {
            graphics.FillEllipse(brush, position.X, position.Y, SIZE, SIZE);
        }
    }
}
