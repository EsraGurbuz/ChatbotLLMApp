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

            // 1. Somut servislerimizi ayaða kaldýrýyoruz
            IChatService chatService = new MockChatService();
            IHistoryService historyService = new HistoryService();

            // 2. Servisleri formun constructor'ýna enjekte ederek uygulamayý baþlatýyoruz
            Application.Run(new MainForm(chatService, historyService));
        }
    }
}