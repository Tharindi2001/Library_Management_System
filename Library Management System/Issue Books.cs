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
    public partial class Issue_Books : Form
    {
        public Issue_Books()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Issue_Books_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-CH2DQMD;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select bName from NewBook", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount;i++)
                {
                    comBKname.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();
        }
        int count;
       

        private void btnsearchst_Click(object sender, EventArgs e)
        {
            if(txtenterEno.Text !="")
            {
                string eid = txtenterEno.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-CH2DQMD;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText="select * from NewStudent where enroll='"+eid+"'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                

                //......................................................
                //Code to count how many book has been issued on this enrollment number
                cmd.CommandText = "select count(st_enroll) from Issuebook where st_enroll='" + eid + "' and book_return_date is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());
                //.......................................................

                if (DS.Tables[0].Rows.Count !=0)
                {
                    txtstname.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtdep.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtsem.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtcontact.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtemail.Text = DS.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtstname.Clear();
                    txtdep.Clear();
                    txtsem.Clear();
                    txtcontact.Clear();
                    txtemail.Clear();
                    MessageBox.Show("Invailed Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIssuebook_Click(object sender, EventArgs e)
        {
            if (txtstname.Text!="")
            {
                if(comBKname.SelectedIndex != -1 && count<=2)
                {
                    string enroll = txtenterEno.Text;
                    string stname = txtstname.Text;
                    string stdep = txtdep.Text;
                    string sem = txtsem.Text;
                    Int64 contact = Int64.Parse(txtcontact.Text);
                    string email = txtemail.Text;
                    string bookname = comBKname.Text;
                    string bookissuedate = txtdateTimePicker1.Text;

                    string eid = txtenterEno.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-CH2DQMD;Initial Catalog=library;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;


                    con.Open();
                    cmd.CommandText = cmd.CommandText="Insert into Issuebook(st_enroll,st_name,st_Dep,st_Sem,st_Contact,st_Email,book_name,book_issue_date)values('" + enroll + "','" + stname + "','" + stdep + "','" + sem + "'," + contact + ",'" + email + "','" + bookname + "','" + bookissuedate + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select Book or Maximum number of Book has been Issued", "No Book selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter valid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtenterEno_TextChanged(object sender, EventArgs e)
        {
            if(txtenterEno.Text =="")
            {
                txtstname.Clear();
                txtdep.Clear();
                txtsem.Clear();
                txtcontact.Clear();
                txtemail.Clear();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtenterEno.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
