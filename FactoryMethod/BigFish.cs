using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class BigFish : IFish
    {
        public void Swim()
        {
            Console.WriteLine($"{nameof(BigFish)} is swimming");
        }
    }
}
