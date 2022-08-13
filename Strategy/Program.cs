namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(3);
            ints.Add(2);
            ints.Add(5);
            ints.Add(4);
            ints.Add(6);

            DataProcessor dp = new DataProcessor(ints, new AscSort());
            var topN1 = dp.GetTopN(3);

            dp = new DataProcessor(ints, new DescSort());
            var topN2 = dp.GetTopN(3);

            topN1.ToList().ForEach(d =>
            {
                Console.Write(d + ","); // 1,2,3
            });
            
            Console.WriteLine();

            topN2.ToList().ForEach(d =>
            {
                Console.Write(d + ","); // 6,5,4
            });

        }
    }
}