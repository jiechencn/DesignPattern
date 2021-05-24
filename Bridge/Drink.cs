using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class Drink
    {
        private Taste taste;
        public Drink(Taste taste)
        {
            this.taste = taste;
        }
        public virtual void Order(int count)
        {
            taste.Mix();
            Console.WriteLine($"Ordered {count} glasses of {taste.ToString()}");
        }
    }
}
