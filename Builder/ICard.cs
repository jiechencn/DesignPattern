namespace Builder
{
    public interface ICard
    {
        string Name { get; set; }
        string CardType { get; set; }
        int Limit { get; set; }
        int AnnualCharge { get; set; }
        string CardDetail { get; }
    }
}