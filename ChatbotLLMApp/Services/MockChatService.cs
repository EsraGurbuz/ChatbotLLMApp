using System.Threading.Tasks;
using ChatbotLLMApp.Interfaces;

namespace ChatbotLLMApp.Services
{
    /// <summary>
    /// A simulated LLM service used for testing and UI development.
    /// </summary>
    public class MockChatService : IChatService
    {
        public async Task<string> GetResponseAsync(string prompt)
        {
            // Simulate network latency (1.5 seconds delay) for realistic AI response behavior
            await Task.Delay(1500);

            if (string.IsNullOrWhiteSpace(prompt))
            {
                return "I received an empty message. How can I assist you today?";
            }

            string lowerPrompt = prompt.ToLower();

            // Simple mock routing logic
            if (lowerPrompt.Contains("hello") || lowerPrompt.Contains("hi"))
            {
                return "Hello! I am your AI Assistant powered by ChatbotLLMApp. How can I help you compile your thoughts today?";
            }
            if (lowerPrompt.Contains("oop"))
            {
                return "Object-Oriented Programming (OOP) is based on 4 pillars: Encapsulation, Abstraction, Inheritance, and Polymorphism. We are currently implementing Abstraction and Encapsulation!";
            }

            return $"[Mock LLM Response]: I received your prompt: \"{prompt}\". System structure is working flawlessly!";
        }
    }
}