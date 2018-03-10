using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class DinnerParty
    {
        internal int numberOfPeople;
        internal int costOfBeveragesPerPerson;
        internal double costOfDecorations;
        internal const int costOfFood = 25;



        public void SetHealthyOption(bool healty)
        {
            if (healty)
            {
                costOfBeveragesPerPerson = 5;
            }
            else
            {
                costOfBeveragesPerPerson = 20;
            }


        }

        public void CalculateCostOfDecorations(bool fancy)
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
            double discount;
            if (costOfBeveragesPerPerson == 5)
            {
                totalCost = 50 + numberOfPeople * (costOfBeveragesPerPerson + costOfDecorations);
                discount = 5 * totalCost / 100;
                totalCost = totalCost - discount;
            }
            else
            {
                totalCost = 30 + numberOfPeople * (costOfBeveragesPerPerson + costOfDecorations);
            }

            return totalCost;


        }

    }
}
