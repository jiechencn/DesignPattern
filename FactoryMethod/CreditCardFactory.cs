using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class CreditCardFactory
    {
        protected abstract ICreditCard Design();

        public ICreditCard MakeCard()
        {
            return Design();
        }

    }
}
