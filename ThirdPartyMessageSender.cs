using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor
{
    /// <summary>
    /// 引入的第三方类，比我们自己的类功能强大。
    /// 角色：adaptee
    /// </summary>
    public class ThirdPartyMessageSender
    {
        public virtual void Post(string content, bool supportEmoj)
        {
            string realContent = content;
            if (supportEmoj)
            {
                // 编码处理，让字符串支持emoji
                realContent = content;
            }
            Console.WriteLine($"emjo supported: {supportEmoj} : {realContent}");
        }
    }
}
