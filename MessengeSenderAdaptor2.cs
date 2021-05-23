using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor
{
    class MessengeSenderAdaptor2 : IMessageSender
    {
        ThirdPartyMessageSender _thirdPartySender;

        public MessengeSenderAdaptor2(ThirdPartyMessageSender thirdPartySender)
        {
            _thirdPartySender = thirdPartySender;
        }
        public void Send(string words)
        {
            _thirdPartySender.Post(words, true);
        }
    }
}
