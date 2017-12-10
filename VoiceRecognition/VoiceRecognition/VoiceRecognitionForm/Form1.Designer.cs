namespace VoiceRecognitionForm
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
            this.enableBtn_Click1 = new System.Windows.Forms.Button();
            this.disableBtn_Click1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conversation_Log
            // 
            this.conversation_Log.Location = new System.Drawing.Point(13, 35);
            this.conversation_Log.Name = "conversation_Log";
            this.conversation_Log.Size = new System.Drawing.Size(558, 355);
            this.conversation_Log.TabIndex = 0;
            this.conversation_Log.Text = "-Log-";
            // 
            // enableBtn_Click1
            // 
            this.enableBtn_Click1.Location = new System.Drawing.Point(47, 484);
            this.enableBtn_Click1.Name = "enableBtn_Click1";
            this.enableBtn_Click1.Size = new System.Drawing.Size(211, 55);
            this.enableBtn_Click1.TabIndex = 1;
            this.enableBtn_Click1.Text = "Enable Voice Recognition";
            this.enableBtn_Click1.UseVisualStyleBackColor = true;
            this.enableBtn_Click1.Click += new System.EventHandler(this.enableBtn_Click1_Click);
            // 
            // disableBtn_Click1
            // 
            this.disableBtn_Click1.Enabled = false;
            this.disableBtn_Click1.Location = new System.Drawing.Point(398, 484);
            this.disableBtn_Click1.Name = "disableBtn_Click1";
            this.disableBtn_Click1.Size = new System.Drawing.Size(223, 55);
            this.disableBtn_Click1.TabIndex = 2;
            this.disableBtn_Click1.Text = "Disable Voice Recognition";
            this.disableBtn_Click1.UseVisualStyleBackColor = true;
            this.disableBtn_Click1.Click += new System.EventHandler(this.disableBtn_Click1_Click);
            // 
            // Voice_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 588);
            this.Controls.Add(this.disableBtn_Click1);
            this.Controls.Add(this.enableBtn_Click1);
            this.Controls.Add(this.conversation_Log);
            this.Name = "Voice_Display";
            this.Text = "Voice Recognition Display";
            this.Load += new System.EventHandler(this.Voice_Display_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox conversation_Log;
        private System.Windows.Forms.Button enableBtn_Click1;
        private System.Windows.Forms.Button disableBtn_Click1;
    }
}

