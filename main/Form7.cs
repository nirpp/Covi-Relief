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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form4 ss = new Form4();
            this.Hide();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 ss = new Form8();
            this.Hide();
            ss.Show();
        }
    }
}
