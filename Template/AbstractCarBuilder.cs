namespace Template
{
    public abstract class AbstractCarBuilder
    {
        protected Car car = new Car();
        public Car Create()
        {
            CreateBody();
            CreateEngine();
            CreateTyre();
            AssemblyAll();
            return car;
        }

        private void CreateEngine()
        {
            Console.WriteLine("Generic engine");
        }

        protected abstract void CreateTyre();

        protected abstract void CreateBody();

        protected virtual void AssemblyAll()
        {
            Console.WriteLine("Generic assemble line");
        }
    }
}
