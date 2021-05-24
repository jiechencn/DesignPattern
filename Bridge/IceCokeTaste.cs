using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class IceCokeTaste : Taste
    {
        public override string Name => "IceCoca";

        public override void Mix()
        {
            Types.Add("Ice");
            Types.Add("Coca");
            base.Mix();
        }
    }
}
