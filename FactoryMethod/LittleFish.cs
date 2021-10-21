using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class LittleFish : IFish
    {
        public void Swim()
        {
            Console.WriteLine($"{nameof(LittleFish)} is swimming");
        }
    }
}
