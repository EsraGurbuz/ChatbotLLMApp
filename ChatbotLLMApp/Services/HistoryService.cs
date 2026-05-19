using System.Collections.Generic;
using ChatbotLLMApp.Interfaces;
using ChatbotLLMApp.Models;

namespace ChatbotLLMApp.Services
{
    /// <summary>
    /// Manages the in-memory chat history session.
    /// </summary>
    public class HistoryService : IHistoryService
    {
        // Encapsulated concrete list, hidden from the outside world
        private readonly List<ChatMessage> _messages;

        public HistoryService()
        {
            _messages = new List<ChatMessage>();
        }

        public void AddMessage(ChatMessage message)
        {
            _messages.Add(message);
        }

        // Exposing the list as read-only IEnumerable to enforce encapsulation
        public IEnumerable<ChatMessage> GetHistory()
        {
            return _messages;
        }

        public void ClearHistory()
        {
            _messages.Clear();
        }
    }
}