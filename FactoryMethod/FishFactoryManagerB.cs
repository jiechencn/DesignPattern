using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    //enum FishTypes
    //{
    //    Little,
    //    Big
    //}
    class FishFactoryManagerB
    {
        private readonly IDictionary<FishTypes, AbstraceFishFactory> factories;
        public FishFactoryManagerB()
        {
            factories = new Dictionary<FishTypes, AbstraceFishFactory>();
            foreach (FishTypes t in Enum.GetValues(typeof(FishTypes)))
            {
                // 创建出 FactoryMethod.LittleFishFactory 这样的实例来
                var factory = (AbstraceFishFactory)Activator.CreateInstance(Type.GetType("FactoryMethod." + Enum.GetName(typeof(FishTypes), t) + "FishFactory"));
                factories.Add(t, factory);
            }
        }

        public AbstraceFishFactory GetFactory(FishTypes type)
        {
            return factories[type];
        }
    }
}
