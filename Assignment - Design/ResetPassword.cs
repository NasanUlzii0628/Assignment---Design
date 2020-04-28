using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment___Design
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string txt = textBox4.Text;
            int len = txt.Length - 1;
            if(!(txt[len] > 47 && txt[len] < 58))
            {
                MessageBox.Show("Тоо оруулна уу");
                textBox4.Text = (txt.Substring(0, len));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            if (t1.Equals(t2))
            {
                MessageBox.Show("Амжилттай хадгалагдлаа.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Дахин оролдоно уу");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
    }
}
