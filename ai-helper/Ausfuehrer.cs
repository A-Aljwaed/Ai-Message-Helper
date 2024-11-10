//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ai_helper
//{
//    internal class ausfuehrer
//    {
//      static  String apiKey = Environment.GetEnvironmentVariable("ai-api");
     


//        static async Task Main(string[] args)
//        {
            
//            string apiUrl = "https://api.cohere.ai/v2/chat"; // API-Endpunkt

//            // Erstelle die Nachricht
//            var userMessageContent = new UserMessageContent("Hello world!");
//            var userMessage = new UserMessage(userMessageContent);

//            var chatRequest = new V2ChatRequest(
//                "command-r-plus",
//                new List<object> { ChatMessageV2.User(userMessage) }
//            );

//            // Serialisiere die Anfrage in JSON
//            string jsonRequest = JsonConvert.SerializeObject(chatRequest);

//            // Sende die HTTP-Anfrage an die Cohere API
//            var client = new HttpClient();
//            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
//            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

//            var response = await client.PostAsync(apiUrl, content);
//            response.EnsureSuccessStatusCode();

//            string responseContent = await response.Content.ReadAsStringAsync();
//            var chatResponse = JsonConvert.DeserializeObject<ChatResponse>(responseContent);

//            // Ausgabe der Antwort
//            Console.WriteLine($"Response: {chatResponse.Text}");
//        }
//    }
//}

