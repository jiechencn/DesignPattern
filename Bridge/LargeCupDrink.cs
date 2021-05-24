using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class LargeCupDrink : Drink
    {
        public LargeCupDrink(Taste taste) : base(taste)
        {
        }

        public override void Order(int count)
        {
            base.Order(count);
            Console.WriteLine("Free gift");
        }
    }
}
