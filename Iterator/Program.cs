namespace Iterator;
class Program
{
    static void Main(string[] args)
    {
        AbstractCollection collection = new NormalCollection();
        for (int i = 0; i < 10; i++)
        {
            collection.Add($"data-{i}");
        }

        AbstractIterator iterator = collection.CreateIterator();
        while(iterator.HasNext())
        {
            var data = iterator.Next();
            Console.WriteLine(data);
        }

        Console.WriteLine("--------------------");

        AbstractCollection collection2 = new ReverseCollection();
        for (int i = 0; i < 10; i++)
        {
            collection2.Add($"data-{i}");
        }

        AbstractIterator iterator2 = collection2.CreateIterator();
        while (iterator2.HasNext())
        {
            var data = iterator2.Next();
            Console.WriteLine(data);
        }
    }
}
