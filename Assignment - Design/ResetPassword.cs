using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment___Design
{
    public partial class ResetPassword : Form
    {
        private string connetionString;
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter adapter;
        String sql = "";
        string newtrehCode ="";
        public ResetPassword()
        {
            InitializeComponent();
            connetionString = @"Data Source=DESKTOP-DLOHQJ8;Initial Catalog=ZenithDataBase;Integrated Security=true";
            cnn = new SqlConnection(connetionString);
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
            string t1 = textBox5.Text;
            string t2 = textBox6.Text;
            if (t1.Equals(t2))
            {
                cnn.Open();
                sql = "update hariltsagch set pass ='"+ t1 +"' where har_code = "+ newtrehCode;
                adapter = new SqlDataAdapter();
                adapter.UpdateCommand = new SqlCommand(sql, cnn);
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                MessageBox.Show("Амжилттай хадгалагдлаа.");
                this.Hide();
            }
            else
            {
                MessageBox.Show(t1+"\n"+t2);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string code = textBox1.Text;
            sql = "Select register from hariltsagch where har_code = " + code;
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string register =( textBox2.Text + textBox3.Text + textBox4.Text).ToUpper();
                if (dataReader.GetValue(0).Equals(register))
                {
                    newtrehCode = code;
                    panel1.Visible = false;
                    panel2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Уучлаарай, таны мэдээлэл алдаатай байна.");
                }
            }
            cnn.Close();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }
    }
}
