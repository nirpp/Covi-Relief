using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace New_MADF_Project
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form4 ss = new Form4();
            this.Hide();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "yes")
            {
                MessageBox.Show("Get tested for Covid-19");
            }

            else if (textBox2.Text == "yes")
            {
                MessageBox.Show("Get tested for Covid-19");
            }
            else if (textBox3.Text == "yes")
            {
                MessageBox.Show("Get tested for Covid-19");
            }
            else if (textBox4.Text == "yes")
            {
                MessageBox.Show("Get tested for Covid-19");
            }
            else
            {
                MessageBox.Show("Safe! But still follow Covid rules");
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
