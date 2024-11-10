
namespace ai_helper
{
    public class V2ChatRequest
    {
        public string Model { get; set; }
        public List<object> Messages { get; set; }

        public V2ChatRequest(string model, List<object> messages)
        {
            Model = model;
            Messages = messages;
        }
    }
}