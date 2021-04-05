namespace RSA
{
    partial class RSAWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSAWindow));
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.q = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.Label();
            this.EncodeTextBox = new System.Windows.Forms.TextBox();
            this.DecodedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EncodedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(211, 6);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(100, 20);
            this.textBox_p.TabIndex = 0;
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(352, 6);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(100, 20);
            this.textBox_q.TabIndex = 1;
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(211, 267);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(100, 20);
            this.textBox_n.TabIndex = 2;
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(352, 267);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(100, 20);
            this.textBox_d.TabIndex = 3;
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(5, 238);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(200, 23);
            this.EncodeButton.TabIndex = 4;
            this.EncodeButton.Text = "Зашифровать";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(211, 238);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(100, 23);
            this.DecodeButton.TabIndex = 5;
            this.DecodeButton.Text = "Расшифровать";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // q
            // 
            this.q.AutoSize = true;
            this.q.BackColor = System.Drawing.Color.Transparent;
            this.q.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.q.Location = new System.Drawing.Point(324, 8);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(22, 13);
            this.q.TabIndex = 7;
            this.q.Text = "q =";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.BackColor = System.Drawing.Color.Transparent;
            this.d.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.d.Location = new System.Drawing.Point(324, 270);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(22, 13);
            this.d.TabIndex = 8;
            this.d.Text = "d =";
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.BackColor = System.Drawing.Color.Transparent;
            this.n.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.n.Location = new System.Drawing.Point(183, 270);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(22, 13);
            this.n.TabIndex = 9;
            this.n.Text = "n =";
            // 
            // EncodeTextBox
            // 
            this.EncodeTextBox.Location = new System.Drawing.Point(5, 32);
            this.EncodeTextBox.Multiline = true;
            this.EncodeTextBox.Name = "EncodeTextBox";
            this.EncodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EncodeTextBox.Size = new System.Drawing.Size(200, 200);
            this.EncodeTextBox.TabIndex = 14;
            // 
            // DecodedTextBox
            // 
            this.DecodedTextBox.Location = new System.Drawing.Point(317, 32);
            this.DecodedTextBox.Multiline = true;
            this.DecodedTextBox.Name = "DecodedTextBox";
            this.DecodedTextBox.ReadOnly = true;
            this.DecodedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DecodedTextBox.Size = new System.Drawing.Size(200, 200);
            this.DecodedTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(183, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "p =";
            // 
            // EncodedTextBox
            // 
            this.EncodedTextBox.AcceptsReturn = true;
            this.EncodedTextBox.Location = new System.Drawing.Point(211, 32);
            this.EncodedTextBox.Multiline = true;
            this.EncodedTextBox.Name = "EncodedTextBox";
            this.EncodedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EncodedTextBox.Size = new System.Drawing.Size(100, 200);
            this.EncodedTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Простые числа для шифровки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(2, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Сгенерированный закрытый ключ:";
            // 
            // RSAWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RSA.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 301);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EncodedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DecodedTextBox);
            this.Controls.Add(this.EncodeTextBox);
            this.Controls.Add(this.n);
            this.Controls.Add(this.d);
            this.Controls.Add(this.q);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.textBox_p);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RSAWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSAEncoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.Label q;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TextBox EncodeTextBox;
        private System.Windows.Forms.TextBox DecodedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EncodedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

