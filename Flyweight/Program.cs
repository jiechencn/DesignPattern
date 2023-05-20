namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee() { Type = "Frontend", Id = 1 },
                new Employee() { Type = "Backend", Id = 2 },
            };
            EmployeeFactory flyweightFactory = EmployeeFactory.GetInstance(employees);

            Employee e1 = flyweightFactory.GetEmployee("Frontend");
            Employee e2 = flyweightFactory.GetEmployee("Mobile");
            Employee e3 = flyweightFactory.GetEmployee("Mobile");


            e1.Work();
            e2.Work();
            e3.Work();

        }
    }
}