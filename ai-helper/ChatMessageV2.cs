using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ai_helper
{
    internal class ChatMessageV2
    {


        public static object User(UserMessage message)
        {
            return new { role = "user", content = message.userMessageContent.content };
        }


    }
}
