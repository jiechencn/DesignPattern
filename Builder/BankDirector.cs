namespace Builder
{
    class BankDirector
    {
        public ICardBuilder Builder { get; set; }
        public void Construct()
        {
            Builder.BuildBlankCard();
            Builder.PrintCardNumber();
            Builder.PrintName();
            Builder.SetCharge();
            Builder.SetLimit();
        }
    }
}