using System;
using System.Windows.Forms;
using ChatbotLLMApp.Interfaces;
using ChatbotLLMApp.Models;

namespace ChatbotLLMApp.UI
{
    public partial class MainForm : Form
    {
        // Dependency Injection fields (Programmed to Interfaces, not Implementations)
        private readonly IChatService _chatService;
        private readonly IHistoryService _historyService;

        /// <summary>
        /// Initializes the form with required services via Dependency Injection.
        /// </summary>
        public MainForm(IChatService chatService, IHistoryService historyService)
        {
            InitializeComponent();

            _chatService = chatService;
            _historyService = historyService;

            // Wire up event handlers programmatically or via designer
            btnSend.Click += BtnSend_Click;
            btnClear.Click += BtnClear_Click;
            txtUserInput.KeyDown += TxtUserInput_KeyDown;
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            string userPrompt = txtUserInput.Text.Trim();
            if (string.IsNullOrEmpty(userPrompt)) return;

            // 1. Disable inputs while waiting for LLM response
            txtUserInput.Clear();
            SetInputState(false);

            // 2. Process and display user message
            var userMessage = new ChatMessage("User", userPrompt);
            _historyService.AddMessage(userMessage);
            AppendMessageToUI(userMessage);

            try
            {
                // 3. Fetch response from the abstract LLM service
                string botResponse = await _chatService.GetResponseAsync(userPrompt);

                // 4. Process and display bot response
                var botMessage = new ChatMessage("AI Assistant", botResponse);
                _historyService.AddMessage(botMessage);
                AppendMessageToUI(botMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error communication with LLM: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 5. Re-enable inputs
                SetInputState(true);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _historyService.ClearHistory();
            rtbChatHistory.Clear();
            rtbChatHistory.AppendText("--- Chat history cleared ---\n\n");
        }

        private void TxtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            // Send message on Enter key without holding Shift
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true; // Prevent default sound or newline
                btnSend.PerformClick();
            }
        }

        private void AppendMessageToUI(ChatMessage message)
        {
            string formattedMessage = $"[{message.Timestamp:HH:mm:ss}] {message.Sender}:\n{message.Content}\n\n";
            rtbChatHistory.AppendText(formattedMessage);

            // Auto-scroll to the bottom of the rich text box
            rtbChatHistory.SelectionStart = rtbChatHistory.Text.Length;
            rtbChatHistory.ScrollToCaret();
        }

        private void SetInputState(bool isEnabled)
        {
            btnSend.Enabled = isEnabled;
            txtUserInput.Enabled = isEnabled;
            if (isEnabled) txtUserInput.Focus();
        }
    }
}