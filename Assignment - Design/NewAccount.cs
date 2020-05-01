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
    public partial class NewAccount : Form
    {
        private string connetionString;
        SqlConnection cnn;
        SqlCommand command;
        private SqlDataAdapter adapter;
        String sql, code = "";
        string dansTurul = "", hadTurul = "", prod = "", tem = "", dans = "";
        public NewAccount(string code)
        {
            InitializeComponent();
            connetionString = @"Data Source=DESKTOP-DLOHQJ8;Initial Catalog=ZenithDataBase;Integrated Security=true";
            cnn = new SqlConnection(connetionString);
            this.code = code;
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

                    cnn.Open();
                    string date = DateTime.Now.ToString("yyy-M-d");
                    DateTime date2 = DateTime.Now.AddDays(1825);
                    sql = "insert into hadgalamjInfo values ("+code+",'"+date+"','"+date2.ToString("yyyy-M-d")+"', 20000)";
                    command = new SqlCommand(sql, cnn);
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();
                    MessageBox.Show("Данс амжилттай нээгдлэээ");
                }
                else
                {
                    MessageBox.Show("Мэдээллээ бүрэн оруулна уу");
                }
            }
            else if (type2.Checked)
            {
                if (combo2.SelectedItem != null)
                {
                    MessageBox.Show("Данс амжилттай нээгдлэээ");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Мэдээллээ бүрэн оруулна уу");
                }
            }
            else if (radioButton1.Checked)
            {
                cnn.Open();
                string date = DateTime.Now.ToString("yyy-M-d");
                DateTime date2 = DateTime.Now.AddDays(1825);
                sql = "insert into hadgalamjInfo values ( '1000'," + code + ",'" + date + "','" + date2.ToString("yyyy-M-d") + "', 20000)";
                MessageBox.Show(sql);
                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                MessageBox.Show("Данс амжилттай нээгдлээ");
                this.Hide();
            }
            else {
                MessageBox.Show("Мэдээллээ бүрэн оруулна уу!");


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

        private void NewAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
