namespace Template
{
    class TeslaBuilder : AbstractCarBuilder
    {
        protected override void CreateBody()
        {
            car.Brand = "Tesla";
        }

        protected override void CreateTyre()
        {
            car.Tyre = "Tesla tyre";
        }

        protected override void AssemblyAll()
        {
            Console.WriteLine("Tesla assemble line");
        }
    }
}
