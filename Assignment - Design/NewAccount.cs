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
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type1.Enabled = true;
            type2.Enabled = true;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type1.Enabled = false;
            type2.Enabled = false;
            product.Enabled = false;
            combo3.Enabled = false;
            product.Text = "";
            combo3.Text = "";
            combo2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type1.Checked)
            {
                if (combo2.SelectedItem != null && combo3.SelectedItem != null && product.SelectedItem != null)
                {
                    MessageBox.Show("Данс амжилттай нээгдлэээ");
                }
                else
                {
                    MessageBox.Show("Мэдээллээ бүрэн оруулна уу");
                }
            }
            else if (type2.Checked) {
                if (combo2.SelectedItem != null)
                {
                    MessageBox.Show("Данс амжилттай нээгдлэээ");
                }
                else
                {
                    MessageBox.Show("Мэдээллээ бүрэн оруулна уу");
                }
            }
            else if(radioButton1.Checked)
            {
                MessageBox.Show("Данс амжилттай нээгдлэээ");
            }
        }

        private void type1_CheckedChanged(object sender, EventArgs e)
        {
            product.Enabled = true;
            combo3.Enabled = true;
        }

        private void type2_CheckedChanged(object sender, EventArgs e)
        {
            product.Enabled = false;
            combo3.Enabled = false;
            product.Text = "";
            combo3.Text = "";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
