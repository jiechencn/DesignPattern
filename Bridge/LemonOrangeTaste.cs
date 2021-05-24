using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class LemonOrangeTaste : Taste
    {
        public override string Name  => "LemonOrange";
        public override void Mix()
        {
            Types.Add("lemon");
            Types.Add("orange");
            base.Mix();
        }
    }
}
