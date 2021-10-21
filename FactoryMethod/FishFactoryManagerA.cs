using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    enum FishTypes
    {
        Little,
        Big
    }
    class FishFactoryManagerA
    {
        private readonly IDictionary<FishTypes, AbstraceFishFactory> factories;
        public FishFactoryManagerA()
        {
            factories = new Dictionary<FishTypes, AbstraceFishFactory>
            {
                { FishTypes.Big, new BigFishFactory() },
                { FishTypes.Little, new LittleFishFactory() },
            };
        }

        public AbstraceFishFactory GetFactory(FishTypes type)
        {
            return factories[type];
        }
    }
}
