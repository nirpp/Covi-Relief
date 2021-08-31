using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace New_MADF_Project
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form4 ss = new Form4();
            this.Hide();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                String name = textBox1.Text;
                long mobile = long.Parse(textBox2.Text);
                String id = textBox3.Text;
                long id_number = long.Parse(textBox4.Text);
                String address = textBox5.Text;

                OleDbConnection con = new OleDbConnection(" Provider=Microsoft.Jet.OleDb.4.0;Data Source='C:\\Users\\Chintan Sawant\\Downloads\\Vaccine.xlsx';Extended Properties=Excel 8.0;");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                String sql = "insert into [Sheet1$](Name,Gender,Mobile,Id,IdNumber,Address,DOV,Type) values('" + name + "','" + this.comboBox1.Text + "'," + mobile + ",'" + id + "'," + id_number + ",'" + address + "','" + this.dateTimePicker1.Text + "','" + this.comboBox2.Text + "')";
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registration Successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(" Provider=Microsoft.Jet.OleDb.4.0;Data Source='C:\\Users\\Chintan Sawant\\Downloads\\Vaccine.xlsx';Extended Properties=Excel 8.0;");
                con.Open();
                String QRY = "Select *from [Sheet1$]";
                OleDbDataAdapter ad = new OleDbDataAdapter(QRY, con);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
