using System;

namespace AbstractFactory
{
    class CardClient
    {
        private ICardFactory cardFactory;
        public CardClient(ICardFactory cardFactory)
        {
            this.cardFactory = cardFactory;
        }

        public void Create()
        {
            ICreditCard credit =  cardFactory.BuildCreditCard();
            IDebitCard debit = cardFactory.BuildDebitCard();
            Console.WriteLine("{0} created by {1}", credit.GetType(), cardFactory.GetType());
            Console.WriteLine("{0} created by {1}", debit.GetType(), cardFactory.GetType());
        }
    }
}
