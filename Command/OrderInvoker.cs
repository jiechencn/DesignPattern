using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class OrderInvoker
    {
        private Queue<ICommand> commands = new Queue<ICommand>();
        public void AddCommand(ICommand command)
        {
            commands.Enqueue(command);
        }

        public void ProcessOrder()
        {
            commands.ToList().ForEach(o => o.Execute());
        }

        internal void Rollback()
        {
            commands.ToList().ForEach(o => o.Unexecute());
        }
    }
}
