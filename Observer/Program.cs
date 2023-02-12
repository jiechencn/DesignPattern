using Observer;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        Subject iphone = new Subject() { Name = "iphone" };
        Subject android = new Subject() { Name = "android" }; ;

        Subscriber tom = new Subscriber() { Name = "Tom" };
        Subscriber jerry = new Subscriber() { Name = "Jerry" };
        tom.Subscribe(iphone);
        tom.Subscribe(android);
        jerry.Subscribe(iphone);
        jerry.Subscribe(android);
        Subscriber mary = new Subscriber() { Name = "Mary" };
        mary.Subscribe(iphone);

        iphone.SetState(1);
        android.SetState(1);

    }
};