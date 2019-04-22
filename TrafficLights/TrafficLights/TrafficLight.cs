using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public class TrafficLight
    {
        private Graphics graphics;
        private List<Light> lights;
        public TrafficLight(Graphics graphics)
        {
            lights = new List<Light>();
            lights.Add(new Light(new Point(100, 100), graphics, Color.Red));
            lights.Add(new Light(new Point(100, 200), graphics, Color.Orange));
            lights.Add(new Light(new Point(100, 300), graphics, Color.Green));

        }
        public void Flash ()
        {
            for (int i = (lights.Count - 1); i >= 0; i--)
            {
                lights[i].Flash();
            }
        }
    }
}
