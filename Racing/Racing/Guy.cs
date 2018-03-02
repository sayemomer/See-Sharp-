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

           Cash = Cash - MyBet.Amount  ;

           MyRadioButton.Text = Name + " has " + (Cash).ToString() + " Taka";
            
        }


        public void ClearBet() {

            MyBet.Amount = 0;
        
        }


        public void PlaceBet(int Amount, int Dog)
        {

           
                MyBet = new Bet();
                MyBet.Amount = Amount;
                MyBet.Dog = Dog;
                MyBet.Bettor = this;

        }


        public void Collect(int Winner) {

           int bet = this.MyBet.PayOut(Winner);

           Cash = Cash + bet;
        
        }






    }
}
