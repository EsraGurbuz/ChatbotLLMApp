using System;
using System.Threading.Tasks;
using ChatbotLLMApp.Interfaces;
using OpenAI.Managers;
using OpenAI;
using OpenAI.ObjectModels.RequestModels;
using OpenAI.ObjectModels;

namespace ChatbotLLMApp.Services
{
    /// <summary>
    /// Production-ready chat service connecting to the official OpenAI API.
    /// </summary>
    public class OpenAIChatService : IChatService
    {
        private readonly OpenAIService _openAiService;

        public OpenAIChatService()
        {
            // Retrieve the API key from environment variables for security production standards
            string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY") ?? "YOUR_BACKUP_API_KEY_HERE";

            _openAiService = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = apiKey
            });
        }

        public async Task<string> GetResponseAsync(string prompt)
        {
            try
            {
                var completionResult = await _openAiService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
                {
                    Messages = new[]
                    {
                        // Setting up system behavior and feeding the user prompt
                        ChatMessage.FromSystem("You are a helpful assistant integrated into ChatbotLLMApp."),
                        ChatMessage.FromUser(prompt)
                    },
                    Model = "gpt-4o-mini" // Budget-friendly and fast model for portfolio projects
                });

                if (completionResult.Successful)
                {
                    return completionResult.Choices[0].Message.Content;
                }
                else
                {
                    // Handle API specific errors elegantly
                    return $"[API Error]: {completionResult.Error?.Message}";
                }
            }
            catch (Exception ex)
            {
                return $"[Connection Error]: Failed to reach LLM provider. Details: {ex.Message}";
            }
        }
    }
}
