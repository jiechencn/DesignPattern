using System;

namespace Adaptor
{
    class Program
    {
        static void Main(string[] args)
        {
            //原有的代码，给客户使用的，发送简单的文字SMS
            IMessageSender smsSender = new TextSender();
            smsSender.Send("hello :)");


            // 通过类适配的方式，让客户使用的。可以发送emoji的SMS
            IMessageSender sender = new MessengeSenderAdaptor();
            sender.Send("hello1 :)");

            //通过对象适配的方式（其实通过对象代理的方式），让客户使用的。可以发送emoji的SMS
            IMessageSender sender2 = new MessengeSenderAdaptor2(new ThirdPartyMessageSender());
            sender2.Send("hello2 :)");
        }
    }
}
