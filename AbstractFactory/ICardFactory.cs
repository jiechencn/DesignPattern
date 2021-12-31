using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface ICardFactory
    {
        public IDebitCard BuildDebitCard();
        public ICreditCard BuildCreditCard();
    }
}
