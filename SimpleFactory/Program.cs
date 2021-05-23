using System;

namespace SimpleFactory
{
    /// <summary>
    /// 简单工厂类，一个父类和多个子类。子类的创建类型，是根据传入的参数标识（比如字符串）在运行时决定的。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard creditCard1 = CreditCardFactory.GetCreditCard("ICBC");
            Console.WriteLine(creditCard1.GetCardDetail());

            ICreditCard creditCard2 = CreditCardFactory.GetCreditCard("CMB");
            Console.WriteLine(creditCard2.GetCardDetail());
        }
    }
}
