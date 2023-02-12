using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class School
    {
        private List<AbstractPeople> peoples = new List<AbstractPeople>();

        public void Add(AbstractPeople people)
        {
            peoples.Add(people);
        }

        public void InviteVisitor(IVisitor visitor)
        {
            foreach(AbstractPeople people in peoples)
            {
                people.Accept(visitor);
            }
        }
    }
}
