namespace Sockets
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
            this.SendMessBtn = new System.Windows.Forms.Button();
            this.MessageTB = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.IpTB = new System.Windows.Forms.TextBox();
            this.MessagesTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendMessBtn
            // 
            this.SendMessBtn.Enabled = false;
            this.SendMessBtn.Location = new System.Drawing.Point(351, 285);
            this.SendMessBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SendMessBtn.Name = "SendMessBtn";
            this.SendMessBtn.Size = new System.Drawing.Size(121, 32);
            this.SendMessBtn.TabIndex = 3;
            this.SendMessBtn.Text = "Отправить";
            this.SendMessBtn.UseVisualStyleBackColor = true;
            this.SendMessBtn.Click += new System.EventHandler(this.SendMessBtn_Click);
            // 
            // MessageTB
            // 
            this.MessageTB.Location = new System.Drawing.Point(100, 290);
            this.MessageTB.Margin = new System.Windows.Forms.Padding(4);
            this.MessageTB.Name = "MessageTB";
            this.MessageTB.Size = new System.Drawing.Size(240, 22);
            this.MessageTB.TabIndex = 1;
            // 
            // lblIP
            // 
            this.lblIP.Location = new System.Drawing.Point(12, 27);
            this.lblIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(93, 23);
            this.lblIP.TabIndex = 2;
            this.lblIP.Text = "IP сервера:";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(347, 63);
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
            this.lblMessage.Location = new System.Drawing.Point(9, 294);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(81, 16);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Сообщение";
            // 
            // IpTB
            // 
            this.IpTB.Location = new System.Drawing.Point(100, 27);
            this.IpTB.Margin = new System.Windows.Forms.Padding(4);
            this.IpTB.Name = "IpTB";
            this.IpTB.ReadOnly = true;
            this.IpTB.Size = new System.Drawing.Size(240, 22);
            this.IpTB.TabIndex = 0;
            // 
            // MessagesTB
            // 
            this.MessagesTB.Location = new System.Drawing.Point(12, 102);
            this.MessagesTB.Multiline = true;
            this.MessagesTB.Name = "MessagesTB";
            this.MessagesTB.ReadOnly = true;
            this.MessagesTB.Size = new System.Drawing.Size(460, 162);
            this.MessagesTB.TabIndex = 4;
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(99, 68);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(241, 22);
            this.LoginTB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.MessagesTB);
            this.Controls.Add(this.IpTB);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.MessageTB);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.SendMessBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMessBtn;
        private System.Windows.Forms.TextBox MessageTB;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox IpTB;
        private System.Windows.Forms.TextBox MessagesTB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label label1;
    }
}

