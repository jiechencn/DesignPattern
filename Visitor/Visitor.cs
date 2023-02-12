using System.ComponentModel;

namespace Visitor
{
    public interface IVisitor
    {
        public void Visit(AbstractPeople people);
    }
    public class Doctor : IVisitor
    {
        public void Visit(AbstractPeople people)
        {
            Console.WriteLine($"{people.Name} is in healthy check");
        }
    }

    public class Examiner : IVisitor
    {
        public void Visit(AbstractPeople people)
        {
            if (people is Student)
            {
                Console.WriteLine($"{people.Name} is in testing");
                ((Student)people).Score = new Random().Next(80, 100);
            }
        }
    }
}
