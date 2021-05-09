using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Age = 18;
            person1.Gender = 'M';
            person1.Fullname = new FullName { FirstName = "Jie1", LastName = "Chen" };
            Console.WriteLine(person1.ToString());
            Console.WriteLine();

            Person person2 = person1.ShallowCopy();
            person1.Age = 28;
            person1.Fullname = new FullName { FirstName = "Jie11", LastName = "Chen" };
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
            Console.WriteLine();

            Person person3 = person1.DeepCopy();
            person1.Age = 38;
            person1.Fullname = new FullName { FirstName = "Jie111", LastName = "Chen" };
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
            Console.WriteLine(person3.ToString());

        }
    }
}
