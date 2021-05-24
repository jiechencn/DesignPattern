using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink iceCoca = new LargeCupDrink(new IceCokeTaste());
            iceCoca.Order(2);

            Drink lemon = new SmallCupDrink(new LemonOrangeTaste());
            lemon.Order(1);
        }
    }
}
