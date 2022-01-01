using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class CreditCardBuilder : ICardBuilder
    {
        public ICard Card { get; set ; }

        public CreditCardBuilder(string name)
        {
            Card = new CreditCard(name);
            
        }
        public void BuildBlankCard()
        {
            Card.CardType = "CreditCard";
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
            Card.AnnualCharge = 200;
        }

        public void SetLimit()
        {
            Card.Limit = 20000;
        }
    }
}
