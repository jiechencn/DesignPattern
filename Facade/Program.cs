using System.Runtime.CompilerServices;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // old way
            SubsystemA a = new SubsystemA();
            a.DoA();
            SubsystemB b = new SubsystemB();
            b.DoB();

            // new way 1
            SubsystemA a1 = new SubsystemA();
            SubsystemB b1 = new SubsystemB();
            Facade f1 = new Facade(a1, b1);
            f1.Do();

            // new way 2
            Facade f2 = new Facade();
            f2.Do();






        }
    }
}