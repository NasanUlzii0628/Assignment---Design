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
    public partial class Form1 : Form
    {
        private string connetionString;
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        String sql;
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(255, 69, 74);
             connetionString = @"Data Source=DESKTOP-DLOHQJ8;Initial Catalog=ZenithDataBase;Integrated Security=true";
            cnn = new SqlConnection(connetionString);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            double huu = 0;
            double total = 0;
            double byday = 0;
            double totalHuu = 0;
            int mongonDun = Convert.ToInt32(textBox1.Text);
            string mongonTemdegt = comboBox1.Text;
            string hugatsaa = comboBox3.Text;
            string hadTorol = comboBox2.Text;
           sql = "select ha.huu from hugatsaa as h join hadgalamj as ha on h.hugatsaa_code = ha.hugatsaa_code where had_ner = N'" + hadTorol + "' and h.honog = " + hugatsaa + " and mongo_code = '" + mongonTemdegt +"'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (dataReader.GetValue(0).Equals(""))
                {
                    // 
                }
                else
                {
                    huu = Convert.ToDouble(dataReader.GetValue(0));
                }
            }
            textBox5.Text = huu + "";
            total = mongonDun * huu / 100 + mongonDun;
            textBox2.Text = total + "";
            byday = (mongonDun * huu / 100) / (Convert.ToInt32(hugatsaa));
            textBox3.Text = byday + "";
            totalHuu = mongonDun * huu / 100;
            textBox4.Text = totalHuu + "";
            cnn.Close();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    
        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            cnn.Open();
            string m_temdegt = comboBox1.Text;
            sql = "select distinct h.honog from hadgalamj as ha join hugatsaa as h on h.hugatsaa_code = ha.hugatsaa_code where mongo_code = '" + m_temdegt + "'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (dataReader.GetValue(0).Equals(""))
                {
                    MessageBox.Show("Уучлаарай, таны нэр нууц үг таарахгүй байна.");
                }
                else
                {
                    comboBox3.Items.Add(dataReader.GetValue(0));
                }
            }
            cnn.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            cnn.Open();
            string m_temdegt = comboBox1.Text;
            string honog = comboBox3.Text;
            sql = "select distinct had_ner from hadgalamj as ha join hugatsaa as h on h.hugatsaa_code = ha.hugatsaa_code where mongo_code = '" + m_temdegt + "' and h.honog = " + honog + ";";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (dataReader.GetValue(0).Equals(""))
                {
                    MessageBox.Show("Уучлаарай, таны нэр нууц үг таарахгүй байна.");
                }
                else
                {
                    comboBox2.Items.Add(dataReader.GetValue(0));
                }
            }
            cnn.Close();
        }
    }
}
