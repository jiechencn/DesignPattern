using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor
{
    /// <summary>
    /// adaptor，用来改造 ThirdPartyMessageSender 
    /// 角色：target
    /// </summary>
    public class MessengeSenderAdaptor : ThirdPartyMessageSender, IMessageSender
    {
        public void Send(string words)
        {
            Post(words, true);
        }
    }
}
