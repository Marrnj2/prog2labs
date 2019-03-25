using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRace
{
    public class Controller
    {
        // Constatns
        private const int HORSES = 4;

        // Feilds
        private Horse[] horses;
        private bool raceOver;
        private string winnerName;

        public Controller(Random random, int finishLine, PictureBox[] pictureBoxes)
        {
            // Initializing Feilds
            raceOver = false;
            winnerName = "";
            horses = new Horse[HORSES];
            horses[0] = new Horse(pictureBoxes[0], random, finishLine, "Daffy");
            horses[1] = new Horse(pictureBoxes[1], random, finishLine, "Taz");
            horses[2] = new Horse(pictureBoxes[2], random, finishLine, "Pepe");
            horses[3] = new Horse(pictureBoxes[3], random, finishLine, "Willy");
        }
        public void StartRace()
        {
            // Sends horses back to the starting position
            for (int i = 0; i < horses.Length; i++)
            {
                horses[i].Restart();
            }
        }
        public void Race()
        {
            // Calls the horse move method and checks to see if they won the race
            if (raceOver == false)
            {
                for (int i = 0; i < horses.Length; i++)
                {
                    horses[i].Move();
                    if (horses[i].CheckForWinner() == true)
                    {

                        raceOver = true;
                        winnerName = horses[i].Name;
                        MessageBox.Show(winnerName + " is the winner");
                    }
                }
            }
        }
        public bool RaceOver { get => raceOver; set => raceOver = value; }
    }
}
