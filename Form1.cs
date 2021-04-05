using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox_p.Text.Length > 0) && (textBox_q.Text.Length > 0))
            {
                long p = Convert.ToInt64(this.textBox_p.Text);
                long q = Convert.ToInt64(this.textBox_q.Text);

                if (RSA.IsTheNumberSimple(p) && RSA.IsTheNumberSimple(q))
                {
                    string s = "";

                    StreamReader sr = new StreamReader("in.txt");

                    while (!sr.EndOfStream)
                    {
                        s += sr.ReadLine();
                    }

                    sr.Close();

                    s = s.ToUpper();

                    long n = p * q;
                    long m = (p - 1) * (q - 1);
                    long d = RSA.Calculate_d(m);
                    long e_ = RSA.Calculate_e(d, m);

                    List<string> result = RSA.RSA_Encode(s, e_, n);

                    StreamWriter sw = new StreamWriter("out1.txt");
                    foreach (string item in result)
                        sw.WriteLine(item);
                    sw.Close();

                    this.textBox_d.Text = d.ToString();
                    this.textBox_n.Text = n.ToString();

                    Process.Start("out1.txt");
                }
                else
                    MessageBox.Show("p или q - не простые числа!");
            }
            else
                MessageBox.Show("Введите p и q!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox_d.Text.Length > 0) && (textBox_n.Text.Length > 0))
            {
                long d = Convert.ToInt64(this.textBox_d.Text);
                long n = Convert.ToInt64(this.textBox_n.Text);

                List<string> input = new List<string>();

                StreamReader sr = new StreamReader("out1.txt");

                while (!sr.EndOfStream)
                {
                    input.Add(sr.ReadLine());
                }

                sr.Close();

                string result = RSA.RSA_Decode(input, d, n);

                StreamWriter sw = new StreamWriter("out2.txt");
                sw.WriteLine(result);
                sw.Close();

                Process.Start("out2.txt");
            }
            else
                MessageBox.Show("Введите секретный ключ!");
        }
    }
}
