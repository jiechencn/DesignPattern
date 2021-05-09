using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class CmbFactory : CardFactory
    {
        public ICreditCard BuildCreditCard()
        {
            return new CmbCreditCard();
        }

        public IDebitCard BuildDebitCard()
        {
            return new CmbDebitCard();
        }
    }
}
