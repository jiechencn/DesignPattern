using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface ICommand
    {
        public void Execute();

        public void Unexecute();
    }

    public class AddToCartCommand : ICommand
    {
        private DataReceiver receiver;
        public AddToCartCommand(DataReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.Action(this);
        }

        public void Unexecute()
        {
            receiver.CancelAction(this);
        }
    }
    public class PayCommand : ICommand
    {
        private DataReceiver receiver;
        public PayCommand(DataReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.Action(this);
        }

        public void Unexecute()
        {
            receiver.CancelAction(this);
        }
    }

    public class ShipCommand : ICommand
    {
        private DataReceiver receiver;
        public ShipCommand(DataReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.Action(this);
        }

        public void Unexecute()
        {
            receiver.CancelAction(this);
        }
    }
}
