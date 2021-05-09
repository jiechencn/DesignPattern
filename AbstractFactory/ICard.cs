namespace AbstractFactory
{
    public interface ICard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
        string GetCardDetail();
    }
}