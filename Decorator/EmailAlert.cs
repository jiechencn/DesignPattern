using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class EmailAlert : AbstractAlert
    {
        public override void Send()
        {
            Console.WriteLine("Send alert via Email");
        }
    }
}
