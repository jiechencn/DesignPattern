using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Visitor
{
    public abstract class AbstractPeople
    {
        public string Name { get; set; }

        public void Accept(IVisitor vistor)
        {
            vistor.Visit(this);
        }
    }

    public class Student : AbstractPeople
    {
        public int Score { get; set; }
    }

    public class Teacher : AbstractPeople
    {
    }
}
