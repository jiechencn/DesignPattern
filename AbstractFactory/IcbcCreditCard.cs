using System;
using System.Runtime.Serialization;

namespace AbstractFactory
{
    [Serializable]
    internal class IcbcCreditCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 300;
        }

        public string GetCardDetail()
        {
            return $"Card: {GetCardType()}, Limit: {GetCreditLimit()}, Charge: {GetAnnualCharge()}";
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