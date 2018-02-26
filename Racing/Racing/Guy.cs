using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Racing
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;


        public void UpdateLabels()
        {
            // Set my label to my bet’s description, and the label on my
            MyLabel.Text = Name + " has bet " + (MyBet.Amount).ToString() + " taka on dog # " + MyBet.Dog;
            // radio button to show my cash (“Joe has 43 bucks”)

            
        }


        public void ClearBet() { }


        public bool PlaceBet(int Amount, int Dog)
        {
            // Place a new bet and store it in my bet field
            MyBet = new Bet();
            MyBet.Amount = Amount;
            MyBet.Dog = Dog;

            // Return true if the guy had enough money to bet

            return true;
        }


        public void Collect(int Winner) { }






    }
}
