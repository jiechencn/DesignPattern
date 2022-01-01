namespace Builder
{
    class DebitCard : ICard
    {
        public string Name { get; set; }
        public DebitCard(string name)
        {
            Name = name;
        }
        public string CardType { get; set; }
        public int Limit { get; set; }
        public int AnnualCharge { get; set; }
        public string CardDetail { get => $"Card: {nameof(DebitCard)}, Limit: {Limit}, Charge: {AnnualCharge}"; }
    }
}