using System;

namespace AbstractFactory
{
    /*
     The Abstract Factory Design Pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes
    In simple words we can say, the Abstract Factory is a super factory that creates other factories. This Factory is also called Factory of other Factories.
     */
    class Program
    {
        static void Main(string[] args)
        {
            ICardFactory cmbFactory = new CmbFactory();
            ICard card1 = cmbFactory.BuildDebitCard();
            Console.WriteLine(card1.GetCardDetail());

            ICardFactory icbcFactory = new IcbcFactory();
            ICard card2 = icbcFactory.BuildCreditCard();
            Console.WriteLine(card2.GetCardDetail());
        }
    }
}
