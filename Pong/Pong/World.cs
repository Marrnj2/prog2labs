using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pong
{
    class World
    {
        private Ball ball;
        public World (Graphics graphics, Size ClientSize)
        {
            ball = new Ball(graphics, ClientSize);
        }
    }
}
