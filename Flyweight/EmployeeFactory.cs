using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class EmployeeFactory
    {
        private static ConcurrentDictionary<string, Employee> employees = new ConcurrentDictionary<string, Employee>();
        private static EmployeeFactory instance = null;
        private static readonly object objectLock = new object();

        public EmployeeFactory(Employee[] emps)
        {
            emps.AsEnumerable().ToList().ForEach(e => employees.TryAdd(e.Type, e));
        }
        public static EmployeeFactory GetInstance(Employee[] emps)
        {
            // double checked locking
            if (instance == null)
            {
                lock (objectLock)
                {
                    if (instance == null)
                    {
                        instance = new EmployeeFactory(emps);
                    }
                }
            }
            return instance;
        }

        public Employee GetEmployee(string type)
        {
            if (employees.TryGetValue(type, out var emp))
            {
                return emp;
            }

            Employee e = new Employee { Type = type, Id = employees.Count + 1 };
            _ = employees.TryAdd(type, e);

            return e;
        }
    }
}
