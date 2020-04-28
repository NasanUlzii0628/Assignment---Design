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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewAccount na = new NewAccount();
            na.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
