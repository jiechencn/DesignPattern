using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class IcbcCreditCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 300;
        }

        public string GetCardDetail()
        {
            return $"Card: {nameof(IcbcCreditCard)}, Limit: {GetCreditLimit()}, Charge: {GetAnnualCharge()}";
        }

        public string GetCardType()
        {
            return nameof(IcbcCreditCard);
        }

        public int GetCreditLimit()
        {
            return 30000;
        }
    }
}
