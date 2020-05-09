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
    public partial class Report : Form
    {
        private string connetionString;
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        String sql;
        String code = "";
        public Report(string code)
        {
            InitializeComponent();
            this.code = code;
            connetionString = @"Data Source=DESKTOP-DLOHQJ8;Initial Catalog=ZenithDataBase;Integrated Security=true";
            cnn = new SqlConnection(connetionString);
            func1(this.code);
        }
        private void func1(string code)
        {
            cnn.Open();
            sql = "select had_code from hadgalamjInfo where har_code = '" + code + "'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (dataReader.GetValue(0).Equals(""))
                {
                    // anything
                }
                else
                {
                    comboBox1.Items.Add(dataReader.GetValue(0));
                    comboBox2.Items.Add(dataReader.GetValue(0));
                }
            }
            cnn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        { 
             cnn.Open();
            string result = "";
            string ehlehOdor = dateTimePicker1.Text;
            string duusahOdor = dateTimePicker2.Text;
            string dansDugaar = comboBox1.Text;
            sql = "select g.guilgee_torol as 'Төрөл', mongon_dun as 'Мөнгөн дүн', ognoo as 'Огноо' from guilgeeInfo as gi join guilgee as g on g.guilgee_code = gi.torol_code where had_code = " + dansDugaar + " and (ognoo between '" + ehlehOdor + "' and '" + duusahOdor + "' ); ";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (dataReader.GetValue(0).Equals(""))
                {
                   // anything
                }
                else
                {
                    result += dataReader.GetValue(0) + "    " + dataReader.GetValue(1) + "    " + dataReader.GetValue(2) + "\n";
                }
            }
            richTextBox1.Text = result;
            result = "";
            cnn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            /* orlogo */
            cnn.Open();
            string result = "";
            string dansDugaar = "";
            string ehlehOdor = dateTimePicker3.Text;
            string duusahOdor = dateTimePicker4.Text;
            dansDugaar = comboBox2.Text;
            if (listBox1.SelectedIndex == 0)
            {
                if (checkBox1.Checked == true)
                {
                    sql = findDansSaraarIn(this.code, ehlehOdor, duusahOdor); 
                }
                else
                {
                    sql = "select year(ognoo) as 'Жил', month(ognoo) as 'Сар', sum(mongon_dun) as 'Мөнгөн дүн' from guilgeeInfo where had_code = '" + dansDugaar + "' and torol_code = 'In' and (ognoo between '" + ehlehOdor + "' and '" + duusahOdor +  "') group by month(ognoo), year(ognoo)";
                }
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetValue(0).Equals(""))
                    {
                        // anything
                    }
                    else
                    {
                        result += dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "   " + dataReader.GetValue(2) + "\n";
                    }
                }
            }
            else if (listBox1.SelectedIndex == 1)
            {
                if (checkBox1.Checked == true)
                {
                    sql = findDansJileerIn(this.code,ehlehOdor, duusahOdor);
                }
                else
                {
                    sql = "select year(ognoo) as 'Жил', sum(mongon_dun) as 'Мөнгөн дүн' from guilgeeInfo where had_code = '" + dansDugaar + "' and torol_code = 'In' and (ognoo between '" + ehlehOdor + "' and '" + duusahOdor + "') group by year(ognoo)";
                }
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetValue(0).Equals(""))
                    {
                        // anything
                    }
                    else
                    {
                        result += dataReader.GetValue(0) + "  " + dataReader.GetValue(1) + "\n";
                    }
                }
            }

            else {
                if (checkBox1.Checked == true)
                {
                    sql = findDansNiitIn(this.code, ehlehOdor, duusahOdor);
                }
                else
                {
                    sql = "select sum(mongon_dun) as 'Мөнгөн дүн' from guilgeeInfo where had_code = '" + dansDugaar + "' and torol_code = 'In'  and (ognoo between '" + ehlehOdor + "' and '" + duusahOdor + "')";
                }
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetValue(0).Equals(""))
                    {
                        // anything
                    }
                    else
                    {
                        result = "Тухайн хугацааны нийт орлого: " + dataReader.GetValue(0);
                    }
                }
            }
            richTextBox2.Text = result;
            result = "";
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* zarlaga */
            cnn.Open();
            string result = "";
            string dansDugaar = "";
            string ehlehOdor = dateTimePicker3.Text;
            string duusahOdor = dateTimePicker4.Text;
            dansDugaar = comboBox2.Text;
            if (listBox1.SelectedIndex == 0)
            {
                if (checkBox1.Checked == true)
                {
                    sql = findDansSaraarOu(this.code, ehlehOdor, duusahOdor);
                }
                else
                {
                    sql = "select year(ognoo) as 'Жил', month(ognoo) as 'Сар', sum(mongon_dun) as 'Мөнгөн дүн' from guilgeeInfo where had_code = '" + dansDugaar + "' and torol_code = 'Ou' and (ognoo between '" + ehlehOdor + "' and '" + duusahOdor + "') group by month(ognoo), year(ognoo)";
                }
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetValue(0).Equals(""))
                    {
                        // anything
                    }
                    else
                    {
                        result += dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "   " + dataReader.GetValue(2) + "\n";
                    }
                }
            }
            else if (listBox1.SelectedIndex == 1)
            {
                if (checkBox1.Checked == true)
                {
                    sql = findDansJileerOu(this.code, ehlehOdor, duusahOdor);
                }
                else
                {
                    sql = "select year(ognoo) as 'Жил', sum(mongon_dun) as 'Мөнгөн дүн' from guilgeeInfo where had_code = '" + dansDugaar + "' and torol_code = 'Ou' and (ognoo between '" + ehlehOdor + "' and '" + duusahOdor + "') group by year(ognoo)";
                }
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetValue(0).Equals(""))
                    {
                        // anything
                    }
                    else
                    {
                        result += dataReader.GetValue(0) + "  " + dataReader.GetValue(1) + "\n";
                    }
                }
            }

            else
            {
                if (checkBox1.Checked == true)
                {
                    sql = findDansNiitOu(this.code, ehlehOdor, duusahOdor);
                }
                else
                {
                    sql = "select sum(mongon_dun) as 'Мөнгөн дүн' from guilgeeInfo where had_code = '" + dansDugaar + "' and torol_code = 'Ou' and (ognoo between '" + ehlehOdor + "' and '" + duusahOdor + "')";
                }
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader.GetValue(0).Equals(""))
                    {
                        // anything
                    }
                    else
                    {
                        result = "Тухайн хугацааны нийт зарлага: " + dataReader.GetValue(0);
                    }
                }
            }
            richTextBox2.Text = result;
            result = "";
            cnn.Close();
        }
        private string findDansSaraarOu(string code, string ehlehOdor, string duusahOdor)
        {
            string result = "";
            result = "select year(ognoo) as 'Жил', month(ognoo) as 'Сар', sum(mongon_dun) as 'Мөнгөн дүн' from guilgeeInfo where had_code in (select had_code from hadgalamjInfo where har_code = '" + code + "') and torol_code = 'Ou'  and (ognoo between '" + ehlehOdor + "' and '" + duusahOdor + "') group by month(ognoo), year(ognoo)";
            return result;
        }
        private string findDansJileerOu(string code, string ehlehOdor, string duusahOdor)
        {
            string result = "";
            result = "select year(ognoo) as 'Жил', sum(mongon_dun) as 'Мөнгөн дүн' from guilgeeInfo where had_code in (select had_code from hadgalamjInfo where har_code = '" + code + "') and torol_code = 'Ou' and (ognoo between '" + ehlehOdor + "' and '" + duusahOdor + "') group by year(ognoo)";
            return result;
        }
        private string findDansNiitOu(string code, string ehlehOdor, string duusahOdor)
        {
            string result = "";
            result = "select sum(mongon_dun) as 'Мөнгөн дүн' from guilgeeInfo where had_code in (select had_code from hadgalamjInfo where har_code = '" + code + "') and torol_code = 'Ou'  and (ognoo between '" + ehlehOdor + "' and '" + duusahOdor + "')";
            return result;
        }
        private string findDansSaraarIn(string code, string ehlehOdor, string duusahOdor)
        {
            string result = "";
            result = "select year(ognoo) as 'Жил', month(ognoo) as 'Сар', sum(mongon_dun) as 'Мөнгөн дүн' from guilgeeInfo where had_code in (select had_code from hadgalamjInfo where har_code = '" + code + "') and torol_code = 'In' and (ognoo between '" + ehlehOdor + "' and '" + duusahOdor + "') group by month(ognoo), year(ognoo)";
            return result;
        }
        private string findDansJileerIn(string code, string ehlehOdor, string duusahOdor)
        {
            string result = "";
            result = "select year(ognoo) as 'Жил', sum(mongon_dun) as 'Мөнгөн дүн' from guilgeeInfo where had_code in (select had_code from hadgalamjInfo where har_code = '" + code + "') and torol_code = 'In' and (ognoo between '" + ehlehOdor + "' and '" + duusahOdor + "') group by year(ognoo)";
            return result;
        }
        private string findDansNiitIn(string code, string ehlehOdor, string duusahOdor)
        {
            string result = "";
            result = "select sum(mongon_dun) as 'Мөнгөн дүн' from guilgeeInfo where had_code in (select had_code from hadgalamjInfo where har_code = '" + code + "') and torol_code = 'In'and (ognoo between '" + ehlehOdor + "' and '" + duusahOdor + "')";
            return result;
        }
    }
}
