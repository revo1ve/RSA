namespace RSA
{
    partial class Form1
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
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.q = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(88, 58);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(100, 20);
            this.textBox_p.TabIndex = 0;
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(603, 57);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(100, 20);
            this.textBox_q.TabIndex = 1;
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(603, 284);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(100, 20);
            this.textBox_n.TabIndex = 2;
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(88, 284);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(100, 20);
            this.textBox_d.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 10;
            // 
            // q
            // 
            this.q.AutoSize = true;
            this.q.Location = new System.Drawing.Point(575, 59);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(22, 13);
            this.q.TabIndex = 7;
            this.q.Text = "q =";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(60, 287);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(22, 13);
            this.d.TabIndex = 8;
            this.d.Text = "d =";
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Location = new System.Drawing.Point(575, 287);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(22, 13);
            this.n.TabIndex = 9;
            this.n.Text = "n =";
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(0, 0);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(100, 23);
            this.p.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "p =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p);
            this.Controls.Add(this.n);
            this.Controls.Add(this.d);
            this.Controls.Add(this.q);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.textBox_p);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label q;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label label2;
    }
}

