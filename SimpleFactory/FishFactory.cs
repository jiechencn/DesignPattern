using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class FishFactory
    {
        public static IFish BuildFish(string size)
        {
            switch (size)
            {
                case "little":
                    return new LittleFish();
                case "big":
                    return new BighFish();
                default:
                    return null;
            }
        }
    }
}
