using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Racing
{
     public class Greyhound 
    {
        public int startingPosition;
        public int racetrackLength=60;
        public PictureBox MyPictureBox ;
        public int Location = 0;
        public Random Randomizer;

        public bool Run()
        {
            // Move forward either 1, 2, 3 or 4 spaces at random
            // Update the position of my PictureBox on the form
            // Return true if I won the race

            if (MyPictureBox.Location.X == racetrackLength)
            {
                MessageBox.Show("hola you wins");
                return true;
            }
            else
            {
                Random Randomizer = new Random();
                Point p = MyPictureBox.Location;
                p.X += Randomizer.Next(-2, 5);
                MyPictureBox.Location = p;

                return false;
            }
        }


        public void TakeStartingPosition()
        {
            Point p = new Point(4);
            MyPictureBox.Location = p;
        }

    }
}
