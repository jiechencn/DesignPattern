using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        SubsystemA a;
        SubsystemB b;
        public Facade(SubsystemA a, SubsystemB b)
        {
            this.a = a;
            this.b = b;
        }

        public Facade()
        {
            a = new SubsystemA();
            b = new SubsystemB();
        }

        public void Do()
        {
            a.DoA();
            b.DoB();
        }
    }
}
