namespace Sockets
{
    partial class Server
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
            this.MessagesTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // MessagesTB
            // 
            this.MessagesTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesTB.Location = new System.Drawing.Point(0, 0);
            this.MessagesTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MessagesTB.Name = "MessagesTB";
            this.MessagesTB.ReadOnly = true;
            this.MessagesTB.Size = new System.Drawing.Size(519, 252);
            this.MessagesTB.TabIndex = 0;
            this.MessagesTB.Text = "";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 252);
            this.Controls.Add(this.MessagesTB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сервер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessagesTB;
    }
}

