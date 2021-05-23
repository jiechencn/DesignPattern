using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface ICardFactory
    {
        public IDebitCard BuildDebitCard();
        public ICreditCard BuildCreditCard();
    }
}
