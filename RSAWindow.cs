using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RSA
{
    public partial class RSAWindow : Form
    {
        public RSAWindow()
        {
            InitializeComponent();

            EncodeTextBox.GotFocus += OnTextToEncodeFocus;
            EncodeTextBox.LostFocus += OnTextToEncodeDefocus;

            EncodeTextBox.Text = "Введите текст для шифровки";
            EncodeTextBox.ForeColor = System.Drawing.Color.Gray;
        }

        public void OnTextToEncodeFocus(object sender, EventArgs e)
        {
            if (EncodeTextBox.Text == "Введите текст для шифровки")
            {
                EncodeTextBox.Text = "";
                EncodeTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        public void OnTextToEncodeDefocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EncodeTextBox.Text))
            {
                EncodeTextBox.Text = "Введите текст для шифровки";
                EncodeTextBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            if ((textBox_p.Text.Length > 0) && (textBox_q.Text.Length > 0))
            {
                long p = Convert.ToInt64(textBox_p.Text);
                long q = Convert.ToInt64(textBox_q.Text);

                if (RSA.IsTheNumberSimple(p) && RSA.IsTheNumberSimple(q))
                {
                    string textForEncryption = EncodeTextBox.Text;

                    long n = p * q;
                    long fi = (p - 1) * (q - 1);
                    long e_ = RSA.Calculate_e(fi);
                    long d = RSA.Calculate_d(e_, fi);

                    List<string> result = RSA.Encode(textForEncryption, e_, n);

                    EncodedTextBox.Text = "";
                    foreach (string item in result)
                        EncodedTextBox.Text += item + Environment.NewLine;

                    textBox_n.Text = n.ToString();
                    textBox_d.Text = d.ToString();
                }
                else
                    MessageBox.Show("p или q - не простые числа!");
            }
            else
                MessageBox.Show("Введите p и q!");
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            if ((textBox_d.Text.Length > 0) && (textBox_n.Text.Length > 0))
            {
                long d = Convert.ToInt64(textBox_d.Text);
                long n = Convert.ToInt64(textBox_n.Text);

                List<string> input = new List<string>();

                foreach (var line in EncodedTextBox.Text.Split(Environment.NewLine.ToCharArray()))
                    if (line.Length > 0)
                        input.Add(line);

                string result = RSA.Decode(input, d, n);

                DecodedTextBox.Text = result;
            }
            else
                MessageBox.Show("Введите секретный ключ!");
        }
    }
}
