using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Employee
    {
        public string Type { get; set; }

        public int Id { get; set; }

        public void Work()
        {
            Console.WriteLine($"Employee ID {Id} is working on {Type} project");
        }
    }
}
