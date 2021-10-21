using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class LittleFish : IFish
    {
        public void Swim()
        {
            Console.WriteLine($"{nameof(LittleFish)} is swimming");
        }
    }
}
