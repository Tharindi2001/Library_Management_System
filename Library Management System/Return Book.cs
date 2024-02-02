using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Return_Book : Form
    {
        public Return_Book()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEnterEno_TextChanged(object sender, EventArgs e)
        {

            if (txtEnterEno.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnsearchst_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-CH2DQMD;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Issuebook where st_enroll ='" + txtEnterEno.Text + "'and book_return_date is NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or no Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Return_Book_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtEnterEno.Clear();
        }
        string bkname;
        string bkdate;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bkname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bkdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtBKname.Text = bkname;
            txtBKissuedate.Text = bkdate;
        }

        private void btn2Return_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-CH2DQMD;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update Issuebook set book_return_date='" + txtdateTimePicker1.Text + "'where st_enroll='" + txtEnterEno.Text + "' and id =" + rowid + "";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Return successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Return_Book_Load(this, null);


        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtEnterEno.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

    }
}
        
    

               
