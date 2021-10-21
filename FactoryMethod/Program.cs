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
            var factory1 = new LittleFishFactory();
            factory1.LetFishSwim();


            var factory2 = new BigFishFactory();
            factory2.LetFishSwim();

            var factory3 = new FishFactoryManagerA().GetFactory(FishTypes.Little);
            factory3.LetFishSwim();

            var factory4 = new FishFactoryManagerB().GetFactory(FishTypes.Big);
            factory4.LetFishSwim();
        }
    }
}
