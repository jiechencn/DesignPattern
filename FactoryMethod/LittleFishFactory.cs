using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class LittleFishFactory : AbstraceFishFactory
    {
        protected override IFish BuildFish()
        {
            return new LittleFish();
        }
    }
}
