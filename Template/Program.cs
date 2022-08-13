using Template;

class Program
{
    public static void Main(string[] args)
    {
        AbstractCarBuilder builder = new TeslaBuilder();
        Car car = builder.Create();

        Console.Write(car.Brand);
    }
}