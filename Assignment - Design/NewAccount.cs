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
        public SqlDataAdapter adapter;
        String sql="", code = "";
        string  temdegt="MNT", dansTurul, dansDelgerenguiTurul;
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
            combo2.Enabled = false;
            product.Text = "";
            combo3.Text = "";
            combo2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (type1.Checked)
            {
                dansTurul = "Hugatsaatai";
                if (combo2.SelectedItem != null && combo3.SelectedItem != null && product.SelectedItem != null)
                {

                    temdegt = combo2.SelectedItem.ToString();
                    dansDelgerenguiTurul = product.SelectedItem.ToString();
                    codeOlodFunction();
                }
                else
                {
                    MessageBox.Show("Мэдээллээ бүрэн оруулна уу");
                }
            }
            else if (type2.Checked)
            {
                dansTurul = "Hugatsaagui";
                if (combo2.SelectedItem != null)
                {
                    temdegt = combo2.SelectedItem.ToString();
                    codeOlodFunction();
                }
                else
                {
                    MessageBox.Show("Мэдээллээ бүрэн оруулна уу");
                }
            }
            else if (radioButton1.Checked)
            {
                dansNeehQuery("1000");
            }
            else {
                MessageBox.Show("Мэдээллээ бүрэн оруулна уу!");


            }
        }
        private void dansNeehQuery(string dansCode) {
            try
            {
                cnn.Open();
                string date = DateTime.Now.ToString("yyy-M-d");
                DateTime date2 = DateTime.Now.AddDays(1825);
                SqlDataAdapter adapter = new SqlDataAdapter();
                sql = "insert into hadgalamjInfo values " +
                    "( '"+dansCode+"'," + code + ",'" + date + "','" + date2.ToString("yyyy-M-d") + "', 20000)";
                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                MessageBox.Show("Данс амжилттай нээгдлээ");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Уучлаарай та дахин оролдоно уу!");
            }
        }
        private void codeOlodFunction()
        {
            string dansCode = "";
            if (dansTurul.Equals("Hugatsaagui"))
            {
                if (temdegt.Equals("USD"))
                {
                    dansCode = "1203";
                }
                else if (temdegt.Equals("CNY"))
                {
                    dansCode = "1202";
                }
            }
            else
            {
                if (dansDelgerenguiTurul.Equals("Энгийн"))
                {
                    if (temdegt.Equals("USD"))
                    {
                        dansCode = "1110";
                    }
                    else if (temdegt.Equals("CNY"))
                    {
                        dansCode = "1106";
                    }
                    else
                    {
                        dansCode = "1101";
                    }
                } 
                else if (dansDelgerenguiTurul.Equals("Хүүхдийн"))
                {
                    dansCode = "1121";
                } 
                else if (dansDelgerenguiTurul.Equals("Хуримтлалын"))
                {
                    dansCode = "1131";
                }
            }
            dansNeehQuery(dansCode);
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
