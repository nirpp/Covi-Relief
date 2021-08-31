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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(" Provider=Microsoft.Jet.OleDb.4.0;Data Source='C:\\Users\\Chintan Sawant\\Documents\\Beds.xlsx';Extended Properties=Excel 8.0;");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 ss = new Form12();
            this.Hide();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            Form13 ss = new Form13();
            this.Hide();
            ss.Show();
        }
    }
}
