namespace VoiceRecognition
{
    partial class Voice_Display
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.conversation_Log = new System.Windows.Forms.RichTextBox();
            this.enableBtn = new System.Windows.Forms.Button();
            this.disableBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conversation_Log
            // 
            this.conversation_Log.Location = new System.Drawing.Point(26, 24);
            this.conversation_Log.Name = "conversation_Log";
            this.conversation_Log.Size = new System.Drawing.Size(541, 373);
            this.conversation_Log.TabIndex = 0;
            this.conversation_Log.Text = "-Log-";
            // 
            // enableBtn
            // 
            this.enableBtn.Location = new System.Drawing.Point(47, 511);
            this.enableBtn.Name = "enableBtn";
            this.enableBtn.Size = new System.Drawing.Size(166, 46);
            this.enableBtn.TabIndex = 1;
            this.enableBtn.Text = "Enable Voice Control";
            this.enableBtn.UseVisualStyleBackColor = true;
            this.enableBtn.Click += new System.EventHandler(this.enableBtn_Click);
            // 
            // disableBtn
            // 
            this.disableBtn.Enabled = false;
            this.disableBtn.Location = new System.Drawing.Point(368, 511);
            this.disableBtn.Name = "disableBtn";
            this.disableBtn.Size = new System.Drawing.Size(170, 46);
            this.disableBtn.TabIndex = 2;
            this.disableBtn.Text = "Disable Voice Control";
            this.disableBtn.UseVisualStyleBackColor = true;
            this.disableBtn.Click += new System.EventHandler(this.disableBtn_Click);
            // 
            // Voice_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 604);
            this.Controls.Add(this.disableBtn);
            this.Controls.Add(this.enableBtn);
            this.Controls.Add(this.conversation_Log);
            this.Name = "Voice_Display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speech Recognition Display";
            this.Load += new System.EventHandler(this.Voice_Display_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox conversation_Log;
        private System.Windows.Forms.Button enableBtn;
        private System.Windows.Forms.Button disableBtn;
    }
}