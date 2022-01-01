using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // with director
            BankDirector director = new BankDirector();
            ICardBuilder builder = new CreditCardBuilder("Jie Chen");
            director.Builder = builder;
            director.Construct();
            ICard card = builder.Card;
            System.Console.WriteLine(card.CardDetail);

            System.Console.WriteLine();

            // without director
            ICardBuilder builder2 = new DebitCardBuilder("Chen Jie");
            builder2.BuildBlankCard();
            builder2.PrintCardNumber();
            builder2.PrintName();
            builder2.SetCharge();
            builder2.SetLimit();
            ICard card2 = builder2.Card;
            System.Console.WriteLine(card2.CardDetail);
        }
    }
}
