namespace WindowsFormsAppJanci
{
    partial class Form1
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
            this.bSend = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.Chat = new System.Windows.Forms.TextBox();
            this.bSend2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSend
            // 
            this.bSend.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSend.Location = new System.Drawing.Point(176, 313);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(54, 20);
            this.bSend.TabIndex = 0;
            this.bSend.Text = "send";
            this.bSend.UseVisualStyleBackColor = false;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 340);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(158, 20);
            this.tbMessage.TabIndex = 1;
            // 
            // Chat
            // 
            this.Chat.Location = new System.Drawing.Point(12, 12);
            this.Chat.Multiline = true;
            this.Chat.Name = "Chat";
            this.Chat.ReadOnly = true;
            this.Chat.Size = new System.Drawing.Size(158, 322);
            this.Chat.TabIndex = 2;
            // 
            // bSend2
            // 
            this.bSend2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSend2.Location = new System.Drawing.Point(176, 339);
            this.bSend2.Name = "bSend2";
            this.bSend2.Size = new System.Drawing.Size(54, 20);
            this.bSend2.TabIndex = 3;
            this.bSend2.Text = "send2";
            this.bSend2.UseVisualStyleBackColor = false;
            this.bSend2.Click += new System.EventHandler(this.bSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 372);
            this.Controls.Add(this.bSend2);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.bSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox Chat;
        private System.Windows.Forms.Button bSend2;
    }
}

