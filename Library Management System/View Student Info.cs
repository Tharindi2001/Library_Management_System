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
    public partial class View_Student_Info : Form
    {
        public View_Student_Info()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtsearchinfo_TextChanged(object sender, EventArgs e)
        {
            if(txtsearchinfo.Text !="")
            {
                label1.Visible = false;
                Image image = Image.FromFile("C:/Users/cro/Pictures/New folder/search1.gif");
                pictureBox1.Image = image;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-CH2DQMD;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from NewStudent1 where enroll LIKE '"+txtsearchinfo.Text+"%'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                label1.Visible = true;
                Image image = Image.FromFile("C:/Users/cro/Pictures/New folder/search.gif");
                pictureBox1.Image = image;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-CH2DQMD;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from NewStudent1";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void View_Student_Info_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-CH2DQMD;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from NewStudent1";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }
        int bid;
        Int64 rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-CH2DQMD;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from NewStudent1 where stid ='" + bid + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowId = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtstname.Text = DS.Tables[0].Rows[0][1].ToString();
            txtenno.Text = DS.Tables[0].Rows[0][2].ToString();
            txtdep.Text = DS.Tables[0].Rows[0][3].ToString();
            txtsem.Text = DS.Tables[0].Rows[0][4].ToString();
            txtcon.Text = DS.Tables[0].Rows[0][5].ToString();
            txtemail.Text = DS.Tables[0].Rows[0][6].ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
            string stname = txtstname.Text;
            string enroll = txtenno.Text;
            string dep = txtdep.Text;
            string sem = txtsem.Text;
            Int64 contact = Int64.Parse(txtcon.Text);
            string email = txtemail.Text;

            if (MessageBox.Show("Data will be updated,Confirm", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-CH2DQMD;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewStudent set stname='" + stname + "',enroll='" + enroll + "',dep='" + dep + "',sem='" + sem + "',contact=" + contact + ",email='" + email + "' where stid='" + rowId + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                View_Student_Info_Load(this, null);
            }
        }

        private void btnRefrsh_Click(object sender, EventArgs e)
        {
            View_Student_Info_Load(this, null);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted,Confirm", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-CH2DQMD;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewStudent1 where stid='"+rowId+"'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                View_Student_Info_Load(this, null);
            }
        }

        private void btncancell_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved data will be lost.", "Are you Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
