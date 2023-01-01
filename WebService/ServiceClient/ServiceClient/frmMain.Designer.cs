namespace ServiceClient
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
            this.EncryptStrTB = new System.Windows.Forms.TextBox();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.lblEncrypt = new System.Windows.Forms.Label();
            this.DecryptStrTB = new System.Windows.Forms.TextBox();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.lblDecrypt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EncryptKeyTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DecryptKeyTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SumArrayBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ArrayCTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ArrayBTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ArrayATB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ResultParamsTB = new System.Windows.Forms.TextBox();
            this.DelDuplsBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ArrayResultTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ArrayTB = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FindWordBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.UppercaseStrTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FrequentWordTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.InitStringTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptStrTB
            // 
            this.EncryptStrTB.Location = new System.Drawing.Point(19, 52);
            this.EncryptStrTB.Margin = new System.Windows.Forms.Padding(4);
            this.EncryptStrTB.Name = "EncryptStrTB";
            this.EncryptStrTB.Size = new System.Drawing.Size(357, 22);
            this.EncryptStrTB.TabIndex = 0;
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(260, 84);
            this.EncryptBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(117, 28);
            this.EncryptBtn.TabIndex = 1;
            this.EncryptBtn.Text = "Шифровать";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.AutoSize = true;
            this.lblEncrypt.Location = new System.Drawing.Point(24, 29);
            this.lblEncrypt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(226, 16);
            this.lblEncrypt.TabIndex = 2;
            this.lblEncrypt.Text = "Введите строку для шифрования:";
            // 
            // DecryptStrTB
            // 
            this.DecryptStrTB.Location = new System.Drawing.Point(16, 149);
            this.DecryptStrTB.Margin = new System.Windows.Forms.Padding(4);
            this.DecryptStrTB.Name = "DecryptStrTB";
            this.DecryptStrTB.Size = new System.Drawing.Size(357, 22);
            this.DecryptStrTB.TabIndex = 2;
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(260, 193);
            this.DecryptBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(117, 28);
            this.DecryptBtn.TabIndex = 3;
            this.DecryptBtn.Text = "Дешифровать";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // lblDecrypt
            // 
            this.lblDecrypt.AutoSize = true;
            this.lblDecrypt.Location = new System.Drawing.Point(21, 129);
            this.lblDecrypt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Size = new System.Drawing.Size(242, 16);
            this.lblDecrypt.TabIndex = 2;
            this.lblDecrypt.Text = "Введите строку для дешифрования:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EncryptKeyTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DecryptKeyTB);
            this.groupBox1.Controls.Add(this.lblEncrypt);
            this.groupBox1.Controls.Add(this.lblDecrypt);
            this.groupBox1.Controls.Add(this.EncryptStrTB);
            this.groupBox1.Controls.Add(this.DecryptStrTB);
            this.groupBox1.Controls.Add(this.DecryptBtn);
            this.groupBox1.Controls.Add(this.EncryptBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 236);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функция 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ключ:";
            // 
            // EncryptKeyTB
            // 
            this.EncryptKeyTB.Location = new System.Drawing.Point(77, 87);
            this.EncryptKeyTB.Name = "EncryptKeyTB";
            this.EncryptKeyTB.Size = new System.Drawing.Size(173, 22);
            this.EncryptKeyTB.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ключ:";
            // 
            // DecryptKeyTB
            // 
            this.DecryptKeyTB.Location = new System.Drawing.Point(77, 193);
            this.DecryptKeyTB.Name = "DecryptKeyTB";
            this.DecryptKeyTB.Size = new System.Drawing.Size(173, 22);
            this.DecryptKeyTB.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SumArrayBtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ArrayCTB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ArrayBTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ArrayATB);
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 227);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Функция 2";
            // 
            // SumArrayBtn
            // 
            this.SumArrayBtn.Location = new System.Drawing.Point(77, 186);
            this.SumArrayBtn.Name = "SumArrayBtn";
            this.SumArrayBtn.Size = new System.Drawing.Size(226, 35);
            this.SumArrayBtn.TabIndex = 6;
            this.SumArrayBtn.Text = "Сложить поэлементно";
            this.SumArrayBtn.UseVisualStyleBackColor = true;
            this.SumArrayBtn.Click += new System.EventHandler(this.SumArrayBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Результат:";
            // 
            // ArrayCTB
            // 
            this.ArrayCTB.Location = new System.Drawing.Point(56, 158);
            this.ArrayCTB.Name = "ArrayCTB";
            this.ArrayCTB.ReadOnly = true;
            this.ArrayCTB.Size = new System.Drawing.Size(317, 22);
            this.ArrayCTB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Массив B:";
            // 
            // ArrayBTB
            // 
            this.ArrayBTB.Location = new System.Drawing.Point(56, 105);
            this.ArrayBTB.Name = "ArrayBTB";
            this.ArrayBTB.Size = new System.Drawing.Size(317, 22);
            this.ArrayBTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Массив А:";
            // 
            // ArrayATB
            // 
            this.ArrayATB.Location = new System.Drawing.Point(56, 55);
            this.ArrayATB.Name = "ArrayATB";
            this.ArrayATB.Size = new System.Drawing.Size(317, 22);
            this.ArrayATB.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.ResultParamsTB);
            this.groupBox3.Controls.Add(this.DelDuplsBtn);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ArrayResultTB);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ArrayTB);
            this.groupBox3.Location = new System.Drawing.Point(447, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 236);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Функция 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Минимум/максимум:";
            // 
            // ResultParamsTB
            // 
            this.ResultParamsTB.Location = new System.Drawing.Point(50, 161);
            this.ResultParamsTB.Name = "ResultParamsTB";
            this.ResultParamsTB.ReadOnly = true;
            this.ResultParamsTB.Size = new System.Drawing.Size(323, 22);
            this.ResultParamsTB.TabIndex = 10;
            // 
            // DelDuplsBtn
            // 
            this.DelDuplsBtn.Location = new System.Drawing.Point(68, 193);
            this.DelDuplsBtn.Name = "DelDuplsBtn";
            this.DelDuplsBtn.Size = new System.Drawing.Size(276, 35);
            this.DelDuplsBtn.TabIndex = 9;
            this.DelDuplsBtn.Text = "Выполнить";
            this.DelDuplsBtn.UseVisualStyleBackColor = true;
            this.DelDuplsBtn.Click += new System.EventHandler(this.DelDuplsBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Результат:";
            // 
            // ArrayResultTB
            // 
            this.ArrayResultTB.Location = new System.Drawing.Point(50, 109);
            this.ArrayResultTB.Name = "ArrayResultTB";
            this.ArrayResultTB.ReadOnly = true;
            this.ArrayResultTB.Size = new System.Drawing.Size(323, 22);
            this.ArrayResultTB.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Массив:";
            // 
            // ArrayTB
            // 
            this.ArrayTB.Location = new System.Drawing.Point(50, 52);
            this.ArrayTB.Name = "ArrayTB";
            this.ArrayTB.Size = new System.Drawing.Size(323, 22);
            this.ArrayTB.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FindWordBtn);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.UppercaseStrTB);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.FrequentWordTB);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.InitStringTB);
            this.groupBox4.Location = new System.Drawing.Point(447, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 229);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Функция 4";
            // 
            // FindWordBtn
            // 
            this.FindWordBtn.Location = new System.Drawing.Point(68, 186);
            this.FindWordBtn.Name = "FindWordBtn";
            this.FindWordBtn.Size = new System.Drawing.Size(276, 31);
            this.FindWordBtn.TabIndex = 17;
            this.FindWordBtn.Text = "Выполнить";
            this.FindWordBtn.UseVisualStyleBackColor = true;
            this.FindWordBtn.Click += new System.EventHandler(this.FindWordBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Верхний регистр:";
            // 
            // UppercaseStrTB
            // 
            this.UppercaseStrTB.Location = new System.Drawing.Point(50, 150);
            this.UppercaseStrTB.Name = "UppercaseStrTB";
            this.UppercaseStrTB.ReadOnly = true;
            this.UppercaseStrTB.Size = new System.Drawing.Size(323, 22);
            this.UppercaseStrTB.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(299, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Самое часто встречающееся слово/предлог:";
            // 
            // FrequentWordTB
            // 
            this.FrequentWordTB.Location = new System.Drawing.Point(50, 105);
            this.FrequentWordTB.Name = "FrequentWordTB";
            this.FrequentWordTB.ReadOnly = true;
            this.FrequentWordTB.Size = new System.Drawing.Size(323, 22);
            this.FrequentWordTB.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Введите строку:";
            // 
            // InitStringTB
            // 
            this.InitStringTB.Location = new System.Drawing.Point(50, 55);
            this.InitStringTB.Name = "InitStringTB";
            this.InitStringTB.Size = new System.Drawing.Size(323, 22);
            this.InitStringTB.TabIndex = 0;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 521);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox EncryptStrTB;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Label lblEncrypt;
        private System.Windows.Forms.TextBox DecryptStrTB;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.Label lblDecrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DecryptKeyTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EncryptKeyTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ArrayCTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ArrayBTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ArrayATB;
        private System.Windows.Forms.Button SumArrayBtn;
        private System.Windows.Forms.Button DelDuplsBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ArrayResultTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ArrayTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ResultParamsTB;
        private System.Windows.Forms.Button FindWordBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox UppercaseStrTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FrequentWordTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox InitStringTB;
    }
}

