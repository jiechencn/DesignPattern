using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class IcbcFactory : CardFactory
    {
        public ICreditCard BuildCreditCard()
        {
            return new IcbcCreditCard();
        }

        public IDebitCard BuildDebitCard()
        {
            return new IcbcDebitCard();
        }
    }
}
