using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class BigFishFactory : AbstraceFishFactory
    {
        protected override IFish BuildFish()
        {
            return new BigFish();
        }
    }
}
