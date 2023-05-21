namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataReceiver receiver = new DataReceiver();
            OrderInvoker invoker = new OrderInvoker();
            invoker.AddCommand(new AddToCartCommand(receiver));
            invoker.AddCommand(new PayCommand(receiver));
            invoker.AddCommand(new ShipCommand(receiver));

            invoker.ProcessOrder();
            invoker.Rollback();

        }
    }
}