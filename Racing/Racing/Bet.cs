using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
   public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;


        public string GetDescription()
        {
            // Return a string that says who placed the bet, how much
            // cash was bet, and which dog he bet on (“Joe bets 8 on
            // dog #4”). If the amount is zero, no bet was placed
            // (“Joe hasn’t placed a bet”)."

            return "joye";
        }


        public int PayOut(int Winner)
        {
            // The parameter is the winner of the race. If the dog won,
            // return the amount bet. Otherwise, return the negative of
            // the amount bet.

            if (Winner == Dog)
            {
                return Amount;
            }

            return -Amount;
        }






    }
}
