using System;

namespace ChatbotLLMApp.Models
{
    /// <summary>
    /// Represents a single message within the chatbot session.
    /// </summary>
    public class ChatMessage
    {
        /// <summary>
        /// Gets or sets the sender type (e.g., "User", "Bot", "System").
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// Gets or sets the text content of the message.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets the exact timestamp when the message was recorded.
        /// </summary>
        public DateTime Timestamp { get; private set; }

        /// <summary>
        /// Initializes a new instance of the ChatMessage class.
        /// </summary>
        /// <param name="sender">The actor who sent the message.</param>
        /// <param name="content">The actual text content.</param>
        public ChatMessage(string sender, string content)
        {
            Sender = sender;
            Content = content;
            Timestamp = DateTime.Now; // Automatically capture the creation time
        }
    }
}