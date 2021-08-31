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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 ss = new Form5();
            this.Hide();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 ss = new Form6();
            this.Hide();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 ss = new Form7();
            this.Hide();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 ss = new Form10();
            this.Hide();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form12 ss = new Form12();
            this.Hide();
            ss.Show();
        }
    }
}
