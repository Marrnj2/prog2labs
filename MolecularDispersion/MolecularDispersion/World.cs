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
    class World
    {
        private const int POPULATE = 50;

        private List<Molecule> molecules;

        public World (Random random, Graphics graphics)
        {
            molecules = new List<Molecule>();
            for (int i = 0; i < POPULATE; i++)
            {
                molecules.Add(new Molecule(new Point(100, 100), Color.Gray, random, graphics));
                molecules.Add(new Molecule(new Point(200, 200), Color.DimGray, random, graphics));
                molecules.Add(new Molecule(new Point(300, 300), Color.LightGray, random, graphics));
            }
        }
        public void Run()
        {
            foreach(Molecule molecule in molecules)
            {
                molecule.Move();
                molecule.Draw();

            }
        }
    }
}
