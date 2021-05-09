using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class IcbcFactory : CreditCardFactory
    {
        protected override ICreditCard Design()
        {
            return new IcbcCreditCard();
        }
    }
}
