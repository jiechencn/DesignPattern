using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class CmbCreditCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 200;
        }

        public string GetCardDetail()
        {
            return $"Card: {nameof(CmbCreditCard)}, Limit: {GetCreditLimit()}, Charge: {GetAnnualCharge()}";
        }

        public string GetCardType()
        {
            return nameof(CmbCreditCard);
        }

        public int GetCreditLimit()
        {
            return 20000;
        }
    }
}
