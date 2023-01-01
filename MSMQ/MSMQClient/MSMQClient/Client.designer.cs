namespace MSMQ
{
    partial class Client
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendMessageBtn = new System.Windows.Forms.Button();
            this.MessageTB = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.QueuePathTB = new System.Windows.Forms.TextBox();
            this.MessagesTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendMessageBtn
            // 
            this.SendMessageBtn.Enabled = false;
            this.SendMessageBtn.Location = new System.Drawing.Point(375, 254);
            this.SendMessageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SendMessageBtn.Name = "SendMessageBtn";
            this.SendMessageBtn.Size = new System.Drawing.Size(121, 32);
            this.SendMessageBtn.TabIndex = 3;
            this.SendMessageBtn.Text = "Отправить";
            this.SendMessageBtn.UseVisualStyleBackColor = true;
            this.SendMessageBtn.Click += new System.EventHandler(this.SendMessageBtn_Click);
            // 
            // MessageTB
            // 
            this.MessageTB.Location = new System.Drawing.Point(98, 259);
            this.MessageTB.Margin = new System.Windows.Forms.Padding(4);
            this.MessageTB.Name = "MessageTB";
            this.MessageTB.Size = new System.Drawing.Size(265, 22);
            this.MessageTB.TabIndex = 1;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(9, 16);
            this.lblIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(108, 16);
            this.lblIP.TabIndex = 2;
            this.lblIP.Text = "Путь к очереди";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(375, 40);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(121, 32);
            this.ConnectBtn.TabIndex = 2;
            this.ConnectBtn.Text = "Подключиться";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(9, 262);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(84, 16);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Сообщение:";
            // 
            // QueuePathTB
            // 
            this.QueuePathTB.Location = new System.Drawing.Point(123, 12);
            this.QueuePathTB.Margin = new System.Windows.Forms.Padding(4);
            this.QueuePathTB.Name = "QueuePathTB";
            this.QueuePathTB.Size = new System.Drawing.Size(240, 22);
            this.QueuePathTB.TabIndex = 0;
            this.QueuePathTB.Text = ".\\private$\\ServerQueue";
            // 
            // MessagesTB
            // 
            this.MessagesTB.Location = new System.Drawing.Point(12, 83);
            this.MessagesTB.Multiline = true;
            this.MessagesTB.Name = "MessagesTB";
            this.MessagesTB.Size = new System.Drawing.Size(484, 164);
            this.MessagesTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин:";
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(67, 48);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(296, 22);
            this.LoginTB.TabIndex = 6;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 299);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessagesTB);
            this.Controls.Add(this.QueuePathTB);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.MessageTB);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.SendMessageBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMessageBtn;
        private System.Windows.Forms.TextBox MessageTB;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox QueuePathTB;
        private System.Windows.Forms.TextBox MessagesTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTB;
    }
}

