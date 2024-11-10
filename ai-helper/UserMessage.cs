namespace ai_helper
{
    internal class UserMessage
    {
        public UserMessageContent userMessageContent {  get; set; }

        public UserMessage(UserMessageContent userMessageContent)
        {
            this.userMessageContent = userMessageContent;
        }
    }
}