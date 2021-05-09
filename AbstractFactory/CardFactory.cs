using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface CardFactory
    {
        public IDebitCard BuildDebitCard();
        public ICreditCard BuildCreditCard();
    }
}
