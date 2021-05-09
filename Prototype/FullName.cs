using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public FullName ShallowCopy()
        {
            FullName newFullname = (FullName)this.MemberwiseClone();
            newFullname.FirstName = String.Intern(FirstName);
            newFullname.LastName = String.Intern(LastName);
            return newFullname;

        }
    }
}
