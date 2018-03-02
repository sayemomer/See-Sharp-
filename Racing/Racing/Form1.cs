using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing
{
    public partial class Form1 : Form 
    {
        public Greyhound[] dogs = new Greyhound[4];
        public Guy[] guys = new Guy[3];


        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add(0);
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);

            dogs[0] = new Greyhound();
            dogs[1] = new Greyhound();
            dogs[2] = new Greyhound();
            dogs[3] = new Greyhound();

            dogs[0].MyPictureBox = pictureBox2;
            dogs[1].MyPictureBox = pictureBox3;
            dogs[2].MyPictureBox = pictureBox4;
            dogs[3].MyPictureBox = pictureBox5;


           /* dogs[0].racetrackLength = pictureBox1.Location.X;
            dogs[1].racetrackLength = pictureBox1.Location.X;
            dogs[2].racetrackLength = pictureBox1.Location.X;
            dogs[3].racetrackLength = pictureBox1.Location.X; */



            guys[0] = new Guy();
            guys[1] = new Guy();
            guys[2] = new Guy();


          
            
            

            guys[0].MyRadioButton = radioButton3;
            guys[1].MyRadioButton = radioButton1;
            guys[2].MyRadioButton = radioButton2;

            guys[0].MyLabel = label5;
            guys[1].MyLabel = label6;
            guys[2].MyLabel = label7;


            guys[0].Cash = 10;
            guys[1].Cash = 5;
            guys[2].Cash = 8;

            guys[0].Name = "Sayem";
            guys[1].Name = "Nobo";
            guys[2].Name = "Rafsan";


            guys[0].MyRadioButton.Text = guys[0].Name+" has " + (guys[0].Cash).ToString() + " Taka";
            guys[1].MyRadioButton.Text = guys[1].Name + " has " + (guys[1].Cash).ToString() + " Taka";
            guys[2].MyRadioButton.Text = guys[2].Name + " has " + (guys[2].Cash).ToString() + " Taka"; 

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


          while ( !dogs[0].Run() )
            {
                dogs[0].Run();
            }
            /* if (!dogs[0].Run())
             {
                 dogs[0].Run();
             }
             else
             {
                 guys[0].Collect(0);
                 guys[0].ClearBet();
                 guys[0].UpdateLabels();
             }*/


            /* for (int i = 0; i <= guys.Length; i++)
             {
                 guys[i].Collect(0);
                 guys[i].UpdateLabels();
             } */

            guys[0].Collect(0);
            guys[0].ClearBet();
            guys[0].UpdateLabels();

            button1.Enabled = false;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = this.radioButton3.Text.Split()[0];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = this.radioButton1.Text.Split()[0];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = this.radioButton2.Text.Split()[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string targetGuy = this.label2.Text;

           for (int i = 0; i < guys.Length; i++)
           {
               if (guys[i].Name == targetGuy)
               {
                  
                   if( guys[i].Cash >= Convert.ToInt32(this.numericUpDown1.Value) ){

                          guys[i].PlaceBet(Convert.ToInt32(this.numericUpDown1.Value),Convert.ToInt32(this.comboBox1.Text));
                          guys[i].UpdateLabels();
                          
                           break;
                   }
                   MessageBox.Show("Insuffecient balance");
               }
           }
          
        }
    }
}
