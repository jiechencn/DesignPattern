using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
        string GetCardDetail();
    }
}
