namespace Builder
{
    class CreditCard : ICard
    {
        public string Name { get; set; }
        public CreditCard(string name)
        {
            Name = name;
        }
        public string CardType { get; set; }
        public int Limit { get; set; }
        public int AnnualCharge { get; set; }
        public string CardDetail { get => $"Card: {nameof(CreditCard)}, Limit: {Limit}, Charge: {AnnualCharge}"; }

    }
}