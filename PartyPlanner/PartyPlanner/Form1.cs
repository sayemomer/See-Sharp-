using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner
{
    public partial class Form1 : Form
    {
        BirthdayParty bParty;
        public string cakeWriting="" ;
        public string surfCakeWriting="" ;

        public Form1()
        {
            InitializeComponent();
            bParty = new BirthdayParty();
            bParty.calculateCostOfDecorations(false);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            bParty.calculateCostOfDecorations(checkBox3.Checked);
            DisplayBirthdayPartyCost();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            bParty.numberOfPeople = Convert.ToInt32( numericUpDown2.Value );

            if (bParty.numberOfPeople <= 4)
            {
                bParty.cakeSize = 40;
                checkCakeWriting();
                DisplayBirthdayPartyCost();
            }
            else
            {
                bParty.cakeSize = 75;
                checkCakeWriting();
                DisplayBirthdayPartyCost();
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            
            cakeWriting= textBox2.Text;
            checkCakeWriting();
           
               
        }

        private void DisplayBirthdayPartyCost()
        {
            double Cost = bParty.CalculateCost();
            textBox3.Text = Cost.ToString();
        }

        private void checkCakeWriting()
        {
            if (bParty.numberOfPeople <= 4)
            {
                if (cakeWriting.Length > 16 )
                {
                    surfCakeWriting = cakeWriting.Substring(0, 16);
                    bParty.letter = surfCakeWriting.Length;
                    textBox2.Text = surfCakeWriting;
                    MessageBox.Show("You cant have more then 16 letter");
                    DisplayBirthdayPartyCost();
                }
                else
                {
                    bParty.letter = cakeWriting.Length;
                    DisplayBirthdayPartyCost();
                }

            }
            else
            {
                if (cakeWriting.Length > 40)
                {
                    MessageBox.Show("You cant have more then 40 letter");
                    surfCakeWriting = cakeWriting.Substring(0, 40);
                    bParty.letter = surfCakeWriting.Length;
                    textBox2.Text = surfCakeWriting;
                    DisplayBirthdayPartyCost();
                }
                else
                {
                    bParty.letter = cakeWriting.Length;
                    DisplayBirthdayPartyCost();
                }

            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
