using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class DebitCardBuilder : ICardBuilder
    {
        public ICard Card { get; set ; }
        public DebitCardBuilder(string name)
        {
            Card = new DebitCard(name);
        }
        public void BuildCard()
        {
            Card.CardType = "DebitCard";
        }

        public void PrintCardNumber()
        {
            Console.WriteLine($"{Card.CardType} card number is printed");
        }

        public void PrintName()
        {
            Console.WriteLine($"{Card.Name} is printed");

        }

        public void SetCharge()
        {
            Card.AnnualCharge = 0;
        }

        public void SetLimit()
        {
            Card.Limit = -1;
        }
    }
}
