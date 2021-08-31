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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 ss = new Form11();
            this.Hide();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 ss = new Form4();
            this.Hide();
            ss.Show();
        }
    }
}
