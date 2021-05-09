using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Person
    {
        public char Gender { get; set; }
        public int Age { get; set; }
        public FullName Fullname {get; set;}

        public Person ShallowCopy()
        {
            return this.MemberwiseClone() as Person;
        }

        public Person DeepCopy()
        {
            Person p = (Person)this.ShallowCopy();
            p.Fullname = Fullname.ShallowCopy();
            return p;
        }

        public override string ToString()
        {
            return $"{Fullname.FirstName} {Fullname.LastName}, {Gender}, {Age}";
        }
    }
}
