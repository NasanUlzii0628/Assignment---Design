using MySql.Data.MySqlClient;
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
    public partial class LogIn : Form
    {
        private string connetionString;
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        String sql;
        public LogIn()
        {
            InitializeComponent();
            connetionString = @"Data Source=DESKTOP-DLOHQJ8;Initial Catalog=ZenithDataBase;Integrated Security=true";
            cnn = new SqlConnection(connetionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string code = textBox1.Text;
            sql = "Select pass from hariltsagch where har_code = " + code;
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string pass = textBox2.Text;
                if (dataReader.GetValue(0).Equals(pass))
                {
                    Home df = new Home(code);
                    df.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Уучлаарай, таны нэр нууц үг таарахгүй байна.");
                }
            }
            cnn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ResetPassword f3 = new ResetPassword();
            f3.Show();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }


    }
}
