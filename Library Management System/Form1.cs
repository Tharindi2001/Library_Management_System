using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Library_Management_System
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = Usernametbox.Text;
            String password = tboxPassword.Text;
            if (username == "thavi" && password == "thavi")
            {
                Dashboard ds = new Dashboard();
                ds.Show();
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwordtbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (tboxPassword.Text == "Password")
            {
                tboxPassword.Clear();

            }
        }

        private void Usernametbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Usernametbox.Text == "Username")
            {
                Usernametbox.Clear();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
