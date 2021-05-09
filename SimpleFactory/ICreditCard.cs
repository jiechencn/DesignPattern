namespace SimpleFactory
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();

        string GetCardDetail();
    }
}