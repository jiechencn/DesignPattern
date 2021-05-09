namespace Builder
{
    public class BankDirector
    {
        public ICardBuilder Builder { get; set; }
        public void Construct()
        {
            Builder.BuildCard();
            Builder.PrintCardNumber();
            Builder.PrintName();
            Builder.SetCharge();
            Builder.SetLimit();
        }
    }
}