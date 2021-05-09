using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string type)
        {
            switch (type)
            {
                case "CMB":
                    return new CmbCreditCard();
                case "ICBC":
                    return new IcbcCreditCard();
                default:
                    return null;
            }
        }
    }
}
