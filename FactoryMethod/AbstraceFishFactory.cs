using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class AbstraceFishFactory
    {
        protected abstract IFish BuildFish();

        public void LetFishSwim()
        {
            var fish = BuildFish();
            fish.Swim();
        }
    }
}
