using System.Threading.Tasks;

namespace ChatbotLLMApp.Interfaces
{
    /// <summary>
    /// Defines the contract for LLM provider services.
    /// </summary>
    public interface IChatService
    {
        /// <summary>
        /// Sends a prompt to the LLM and returns the text response asynchronously.
        /// </summary>
        /// <param name="prompt">The user input message.</param>
        /// <returns>The AI generated response.</returns>
        Task<string> GetResponseAsync(string prompt);
    }
}