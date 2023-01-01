namespace MailSlots
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
            this.lblMailSlot = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.MailSlotTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.MessagesTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendMessBtn
            // 
            this.SendMessBtn.Enabled = false;
            this.SendMessBtn.Location = new System.Drawing.Point(366, 267);
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
            this.MessageTB.Location = new System.Drawing.Point(116, 272);
            this.MessageTB.Margin = new System.Windows.Forms.Padding(4);
            this.MessageTB.Name = "MessageTB";
            this.MessageTB.Size = new System.Drawing.Size(240, 22);
            this.MessageTB.TabIndex = 1;
            // 
            // lblMailSlot
            // 
            this.lblMailSlot.AutoSize = true;
            this.lblMailSlot.Location = new System.Drawing.Point(16, 16);
            this.lblMailSlot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMailSlot.Name = "lblMailSlot";
            this.lblMailSlot.Size = new System.Drawing.Size(93, 32);
            this.lblMailSlot.TabIndex = 2;
            this.lblMailSlot.Text = "Введите имя \r\nмейлслота";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(362, 56);
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
            this.lblMessage.Location = new System.Drawing.Point(16, 275);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(81, 16);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Сообщение";
            // 
            // MailSlotTB
            // 
            this.MailSlotTB.Location = new System.Drawing.Point(126, 21);
            this.MailSlotTB.Margin = new System.Windows.Forms.Padding(4);
            this.MailSlotTB.Name = "MailSlotTB";
            this.MailSlotTB.Size = new System.Drawing.Size(230, 22);
            this.MailSlotTB.TabIndex = 0;
            this.MailSlotTB.Text = "\\\\*\\mailslot\\ServerMailslot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите логин";
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(126, 61);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(229, 22);
            this.LoginTB.TabIndex = 5;
            // 
            // MessagesTB
            // 
            this.MessagesTB.Location = new System.Drawing.Point(19, 105);
            this.MessagesTB.Multiline = true;
            this.MessagesTB.Name = "MessagesTB";
            this.MessagesTB.Size = new System.Drawing.Size(468, 155);
            this.MessagesTB.TabIndex = 6;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 312);
            this.Controls.Add(this.MessagesTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MailSlotTB);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblMailSlot);
            this.Controls.Add(this.MessageTB);
            this.Controls.Add(this.ConnectBtn);
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
        private System.Windows.Forms.TextBox MessageTB;
        private System.Windows.Forms.Label lblMailSlot;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox MailSlotTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox MessagesTB;
    }
}

