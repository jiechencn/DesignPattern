using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class DataReceiver
    {
        public void Action(ICommand command)
        {
            Console.WriteLine($"execute {command.GetType()} and save to database");
        }

        public void CancelAction(ICommand command)
        {
            Console.WriteLine($"cancel {command.GetType()} and update to database");
        }
    }
}
