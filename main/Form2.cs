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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {

            if (textBox2.Text == "user1" && textBox3.Text == "1234")
            {
                Form3 ss = new Form3();
                this.Hide();
                ss.Show();
            }
            else
            {
                MessageBox.Show("incorrect !!!!!");
                textBox2.Clear();
                textBox3.Clear();
                textBox2.Focus();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            }
        }
    }

