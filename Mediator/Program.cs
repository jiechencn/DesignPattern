

using Mediator;

class Program
{
    static void Main(string[] args)
    {
        IPress press = new CentralPress();
        AbstractMedia m1 = new Media(press, "m1");
        AbstractMedia m2 = new Media(press, "m2");
        AbstractMedia m3 = new Media(press, "m3");

        Console.WriteLine("-----------------");
        m1.Send("hello, this is a bad news");

        Console.WriteLine("-----------------");
        m2.Send("hello, this is anoter bad news");

        Console.WriteLine("-----------------");
        m3.Send("hello, this is a real good news");
    }
}