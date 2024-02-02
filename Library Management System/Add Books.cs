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

namespace Library_Management_System
{
    public partial class Add_Books : Form
    {
        public Add_Books()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBKname.Text != "" && txtAname.Text != "" && txtPname.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {
                string bName = txtBKname.Text;
                string bAuthor = txtAname.Text;
                string bPubi = txtPname.Text;
                string bDate = dateTimePicker1.Text;
                Int64 bPrice = Int64.Parse(txtPrice.Text);
                Int64 bQuan = Int64.Parse(txtQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-CH2DQMD;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook(bName,bAuthor,bPubi,bPDate,bPrice,bQuan) values('" + bName + "','" + bAuthor + "','" + bPubi + "','" + bDate + "'," + bPrice + "," + bQuan + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBKname.Clear();
                txtAname.Clear();
                txtPname.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();


            }

            else
            {
                MessageBox.Show("Empty field NOT Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your data", "Are you sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
