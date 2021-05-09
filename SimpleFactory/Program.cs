using System;

namespace SimpleFactory
{
    /*
     if we have a superclass and n number of subclasses, and based on the data provided, 
     if we have to create and return the object of one of the subclasses, then we need to use the factory design pattern.
     The basic principle behind the factory design pattern is that, at run time, we get an object of similar type based on the parameter we pass. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard creditCard1 = CreditCardFactory.GetCreditCard("ICBC");
            Console.WriteLine(creditCard1.GetCardDetail());

            ICreditCard creditCard2 = CreditCardFactory.GetCreditCard("CMB");
            Console.WriteLine(creditCard2.GetCardDetail());
        }
    }
}
