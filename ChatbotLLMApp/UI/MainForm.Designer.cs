namespace ChatbotLLMApp.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtbChatHistory = new RichTextBox();
            txtUserInput = new TextBox();
            btnSend = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // rtbChatHistory
            // 
            rtbChatHistory.Dock = DockStyle.Top;
            rtbChatHistory.Location = new Point(0, 0);
            rtbChatHistory.Name = "rtbChatHistory";
            rtbChatHistory.ReadOnly = true;
            rtbChatHistory.Size = new Size(582, 284);
            rtbChatHistory.TabIndex = 0;
            rtbChatHistory.Text = "";
            // 
            // txtUserInput
            // 
            txtUserInput.Location = new Point(13, 291);
            txtUserInput.Multiline = true;
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(457, 69);
            txtUserInput.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(476, 291);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 34);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(476, 331);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear Chat";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 372);
            Controls.Add(btnClear);
            Controls.Add(btnSend);
            Controls.Add(txtUserInput);
            Controls.Add(rtbChatHistory);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AI Chatbot Assistant (LLM Portfolio)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbChatHistory;
        private TextBox txtUserInput;
        private Button btnSend;
        private Button btnClear;
    }
}
