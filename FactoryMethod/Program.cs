using System;

namespace FactoryMethod
{
    /*
    The Factory Method Design Pattern is used, 
    when we need to create the object (i.e. instance of the Product class) without exposing the object creation logic to the client. 
    To achieve this, in the factory method design pattern we will create an abstract class as the Factory class which will create and return the instance of the product, 
    but it will let the subclasses decide which class to instantiate.
     */
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard cmbCard = new CmbFactory().MakeCard();
            Console.WriteLine(cmbCard.GetCardDetail());

            ICreditCard icbcCard = new IcbcFactory().MakeCard();
            Console.WriteLine(icbcCard.GetCardDetail());
        }
    }
}
