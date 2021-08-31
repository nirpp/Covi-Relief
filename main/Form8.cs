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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form7 ss = new Form7();
            this.Hide();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 ss = new Form9();
            this.Hide();
            ss.Show();
        }
    }
}
