using System;
using System.Windows.Forms;
using ChatbotLLMApp.Interfaces;
using ChatbotLLMApp.Services;
using ChatbotLLMApp.UI;

namespace ChatbotLLMApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. We occasionally discontinue our tangible services.

            IChatService chatService = new OpenAIChatService();
            IHistoryService historyService = new HistoryService();

            // 2. Inject services into the form's constructor and start the application
            Application.Run(new MainForm(chatService, historyService));
        }
    }
}