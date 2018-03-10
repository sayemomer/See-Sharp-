using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class BirthdayParty
    {
        public int numberOfPeople=0;
        public double costOfDecorations;
        public int cakeSize; 
        public int letter;
        public const double perLetterCost = 0.25;
        public const int perPersonCost = 25;

        public void calculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                costOfDecorations = 15;
            }
            else
            {
                costOfDecorations = 7.50;
            }
        }


        public double CalculateCost()
        {
            double totalCost;

            if (costOfDecorations == 7.50)
            {
                totalCost = (letter * perLetterCost) + 30 +cakeSize+ (numberOfPeople * (perPersonCost + costOfDecorations));
            }
            else
            {
                totalCost = (letter * perLetterCost) + 50 +cakeSize+ (numberOfPeople * (perPersonCost + costOfDecorations)); 
            }

            return totalCost;

        }



    }

}
