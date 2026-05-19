using System.Collections.Generic;
using ChatbotLLMApp.Models;

namespace ChatbotLLMApp.Interfaces
{
    /// <summary>
    /// Defines the contract for managing chat session history.
    /// </summary>
    public interface IHistoryService
    {
        /// <summary>
        /// Adds a message to the active chat history.
        /// </summary>
        void AddMessage(ChatMessage message);

        /// <summary>
        /// Retrieves all messages from the current session.
        /// </summary>
        IEnumerable<ChatMessage> GetHistory();

        /// <summary>
        /// Clears the current chat session history.
        /// </summary>
        void ClearHistory();
    }
}