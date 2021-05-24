
using System.Collections.Generic;

namespace Bridge
{
    public abstract class Taste
    {
        public List<string> Types { get; set; } = new List<string>();
        public virtual string Name { get; }

        public virtual void Mix()
        {
            System.Console.WriteLine($"mix {string.Join(", ", Types.ToArray())}");
        }

        public override string ToString()
        {
            return $"{Name}: {string.Join(",", Types.ToArray())}";
        }
    }
}