using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor
{
    /// <summary>
    /// 现有的代码，接口。
    /// 角色： target
    /// </summary>
    public interface IMessageSender
    {
        public void Send(string words);
    }
}
