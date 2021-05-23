using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor
{
    /// <summary>
    /// 现有的代码，实现接口
    /// </summary>
    class TextSender : IMessageSender
    {
        public void Send(string words)
        {
            Console.WriteLine(words);
        }
    }
}
