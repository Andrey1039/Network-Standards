namespace Pipes
{
    partial class Client
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
            this.SendMessBtn = new System.Windows.Forms.Button();
            this.lblPipe = new System.Windows.Forms.Label();
            this.ChannelNameTB = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.MessageTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NicknameTB = new System.Windows.Forms.TextBox();
            this.MessagesTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SendMessBtn
            // 
            this.SendMessBtn.Location = new System.Drawing.Point(382, 302);
            this.SendMessBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SendMessBtn.Name = "SendMessBtn";
            this.SendMessBtn.Size = new System.Drawing.Size(100, 28);
            this.SendMessBtn.TabIndex = 2;
            this.SendMessBtn.Text = "Отправить";
            this.SendMessBtn.UseVisualStyleBackColor = true;
            this.SendMessBtn.Click += new System.EventHandler(this.SendMessbtn_Click);
            // 
            // lblPipe
            // 
            this.lblPipe.AutoSize = true;
            this.lblPipe.Location = new System.Drawing.Point(19, 21);
            this.lblPipe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPipe.Name = "lblPipe";
            this.lblPipe.Size = new System.Drawing.Size(86, 16);
            this.lblPipe.TabIndex = 1;
            this.lblPipe.Text = "Имя канала:";
            // 
            // ChannelNameTB
            // 
            this.ChannelNameTB.Location = new System.Drawing.Point(113, 18);
            this.ChannelNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.ChannelNameTB.Name = "ChannelNameTB";
            this.ChannelNameTB.Size = new System.Drawing.Size(369, 22);
            this.ChannelNameTB.TabIndex = 0;
            this.ChannelNameTB.Text = "\\\\.\\pipe\\ServerPipe";
            this.ChannelNameTB.TextChanged += new System.EventHandler(this.ChannelNameTB_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(16, 308);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(84, 16);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Сообщение:";
            // 
            // MessageTB
            // 
            this.MessageTB.Location = new System.Drawing.Point(108, 305);
            this.MessageTB.Margin = new System.Windows.Forms.Padding(4);
            this.MessageTB.Name = "MessageTB";
            this.MessageTB.Size = new System.Drawing.Size(264, 22);
            this.MessageTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ник: ";
            // 
            // NicknameTB
            // 
            this.NicknameTB.Location = new System.Drawing.Point(63, 69);
            this.NicknameTB.Name = "NicknameTB";
            this.NicknameTB.Size = new System.Drawing.Size(419, 22);
            this.NicknameTB.TabIndex = 4;
            // 
            // MessagesTB
            // 
            this.MessagesTB.Location = new System.Drawing.Point(22, 126);
            this.MessagesTB.Name = "MessagesTB";
            this.MessagesTB.ReadOnly = true;
            this.MessagesTB.Size = new System.Drawing.Size(460, 145);
            this.MessagesTB.TabIndex = 5;
            this.MessagesTB.Text = "";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 343);
            this.Controls.Add(this.MessagesTB);
            this.Controls.Add(this.NicknameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageTB);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.ChannelNameTB);
            this.Controls.Add(this.lblPipe);
            this.Controls.Add(this.SendMessBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMessBtn;
        private System.Windows.Forms.Label lblPipe;
        private System.Windows.Forms.TextBox ChannelNameTB;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox MessageTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NicknameTB;
        private System.Windows.Forms.RichTextBox MessagesTB;
    }
}