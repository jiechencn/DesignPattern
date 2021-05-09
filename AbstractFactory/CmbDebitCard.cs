namespace AbstractFactory
{
    internal class CmbDebitCard : IDebitCard
    {
        public int GetAnnualCharge()
        {
            return 0;
        }

        public string GetCardDetail()
        {
            return $"Card: {GetCardType()}, Limit: {GetCreditLimit()}, Charge: {GetAnnualCharge()}";
        }

        public string GetCardType()
        {
            return nameof(CmbDebitCard);
        }

        public int GetCreditLimit()
        {
            return -1;
        }
    }
}