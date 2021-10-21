using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class BighFish : IFish
    {
        public void Swim()
        {
            Console.WriteLine($"{nameof(BighFish)} is swimming");
        }
    }
}
