namespace AbstractFactory
{
    internal class CmbCreditCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 200;
        }

        public string GetCardDetail()
        {
            return $"Card: {GetCardType()}, Limit: {GetCreditLimit()}, Charge: {GetAnnualCharge()}";
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