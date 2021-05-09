using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            China china1 = China.GetInstance();
            China china2 = China.GetInstance();

            Console.WriteLine(china1 == china2);

            USA usa1 = USA.GetInstance();
            USA usa2 = USA.GetInstance();

            Console.WriteLine(usa1 == usa2);

        }
    }
}
