using Newtonsoft.Json;
using System.Text;

namespace ai_helper
{
    public partial class loadingscreen : Form
    {
       


        string apiUrl = "https://api.cohere.ai/v2/chat";


        public loadingscreen()
        {
            InitializeComponent();
        }





        private void button5_Click_1(object sender, EventArgs e)
        {
            connectAPIAsync(textBox2.Text);




        }

        private async Task connectAPIAsync(String message)
        {
            var apiKey = Environment.GetEnvironmentVariable("ai-api");
            string apiUrl = "https://api.cohere.ai/v2/chat";

            var userMessageContent = new UserMessageContent(message);
            var userMessage = new UserMessage(userMessageContent);

            var chatRequest = new V2ChatRequest(
                "command-r-plus",
                new List<object> { ChatMessageV2.User(userMessage) }
            );

            string jsonRequest = JsonConvert.SerializeObject(chatRequest);

            try
            {
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(apiUrl, content);
                response.EnsureSuccessStatusCode();

                string responseContent = await response.Content.ReadAsStringAsync();

                // Deserialisiere die Antwort in ein ChatResponse-Objekt
                ChatResponse chatResponse = JsonConvert.DeserializeObject<ChatResponse>(responseContent);

                // Extrahiere den Text der Antwort des Chatbots
                string botResponseText = chatResponse?.message?.content?.FirstOrDefault()?.text;

                if (!string.IsNullOrEmpty(botResponseText))
                {
                    textBox2.Text = $"Antwort: {botResponseText}";
                }
                else
                {
                    textBox2.Text = "Keine Antwort erhalten.";
                }
            }
            catch (Exception ex)
            {
                textBox2.Text = $"Fehler: {ex.Message}";
            }
        }

    }
}
