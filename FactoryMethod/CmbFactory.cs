using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class CmbFactory : CreditCardFactory
    {
        protected override ICreditCard Design()
        {
            return new CmbCreditCard();
        }
    }
}
