
namespace Library_Management_System
{
    partial class View_Student_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Student_Info));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsearchinfo = new System.Windows.Forms.TextBox();
            this.btnRefrsh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncancell = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.txtsem = new System.Windows.Forms.TextBox();
            this.txtdep = new System.Windows.Forms.TextBox();
            this.txtenno = new System.Windows.Forms.TextBox();
            this.txtstname = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbcon = new System.Windows.Forms.Label();
            this.lbsem = new System.Windows.Forms.Label();
            this.lbdep = new System.Windows.Forms.Label();
            this.lbenroll = new System.Windows.Forms.Label();
            this.lbstname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 112);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(470, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(470, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "View";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enrollment No";
            // 
            // txtsearchinfo
            // 
            this.txtsearchinfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchinfo.Location = new System.Drawing.Point(388, 140);
            this.txtsearchinfo.Name = "txtsearchinfo";
            this.txtsearchinfo.Size = new System.Drawing.Size(141, 23);
            this.txtsearchinfo.TabIndex = 4;
            this.txtsearchinfo.TextChanged += new System.EventHandler(this.txtsearchinfo_TextChanged);
            // 
            // btnRefrsh
            // 
            this.btnRefrsh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefrsh.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrsh.Location = new System.Drawing.Point(548, 140);
            this.btnRefrsh.Name = "btnRefrsh";
            this.btnRefrsh.Size = new System.Drawing.Size(75, 23);
            this.btnRefrsh.TabIndex = 5;
            this.btnRefrsh.Text = "Refrsh";
            this.btnRefrsh.UseVisualStyleBackColor = true;
            this.btnRefrsh.Click += new System.EventHandler(this.btnRefrsh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 205);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btncancell);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.txtemail);
            this.panel2.Controls.Add(this.txtcon);
            this.panel2.Controls.Add(this.txtsem);
            this.panel2.Controls.Add(this.txtdep);
            this.panel2.Controls.Add(this.txtenno);
            this.panel2.Controls.Add(this.txtstname);
            this.panel2.Controls.Add(this.lbemail);
            this.panel2.Controls.Add(this.lbcon);
            this.panel2.Controls.Add(this.lbsem);
            this.panel2.Controls.Add(this.lbdep);
            this.panel2.Controls.Add(this.lbenroll);
            this.panel2.Controls.Add(this.lbstname);
            this.panel2.Location = new System.Drawing.Point(2, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 247);
            this.panel2.TabIndex = 7;
            // 
            // btncancell
            // 
            this.btncancell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancell.Location = new System.Drawing.Point(736, 202);
            this.btncancell.Name = "btncancell";
            this.btncancell.Size = new System.Drawing.Size(75, 23);
            this.btncancell.TabIndex = 14;
            this.btncancell.Text = "Cancell";
            this.btncancell.UseVisualStyleBackColor = true;
            this.btncancell.Click += new System.EventHandler(this.btncancell_Click);
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(618, 202);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(494, 202);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(567, 147);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(225, 20);
            this.txtemail.TabIndex = 11;
            // 
            // txtcon
            // 
            this.txtcon.Location = new System.Drawing.Point(567, 98);
            this.txtcon.Name = "txtcon";
            this.txtcon.Size = new System.Drawing.Size(225, 20);
            this.txtcon.TabIndex = 10;
            // 
            // txtsem
            // 
            this.txtsem.Location = new System.Drawing.Point(567, 46);
            this.txtsem.Name = "txtsem";
            this.txtsem.Size = new System.Drawing.Size(225, 20);
            this.txtsem.TabIndex = 9;
            // 
            // txtdep
            // 
            this.txtdep.Location = new System.Drawing.Point(175, 147);
            this.txtdep.Name = "txtdep";
            this.txtdep.Size = new System.Drawing.Size(225, 20);
            this.txtdep.TabIndex = 8;
            // 
            // txtenno
            // 
            this.txtenno.Location = new System.Drawing.Point(175, 98);
            this.txtenno.Name = "txtenno";
            this.txtenno.Size = new System.Drawing.Size(225, 20);
            this.txtenno.TabIndex = 7;
            // 
            // txtstname
            // 
            this.txtstname.Location = new System.Drawing.Point(175, 46);
            this.txtstname.Name = "txtstname";
            this.txtstname.Size = new System.Drawing.Size(225, 20);
            this.txtstname.TabIndex = 6;
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(455, 150);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(72, 13);
            this.lbemail.TabIndex = 5;
            this.lbemail.Text = "Student Email";
            // 
            // lbcon
            // 
            this.lbcon.AutoSize = true;
            this.lbcon.Location = new System.Drawing.Point(455, 101);
            this.lbcon.Name = "lbcon";
            this.lbcon.Size = new System.Drawing.Size(84, 13);
            this.lbcon.TabIndex = 4;
            this.lbcon.Text = "Student Contact";
            // 
            // lbsem
            // 
            this.lbsem.AutoSize = true;
            this.lbsem.Location = new System.Drawing.Point(455, 49);
            this.lbsem.Name = "lbsem";
            this.lbsem.Size = new System.Drawing.Size(91, 13);
            this.lbsem.TabIndex = 3;
            this.lbsem.Text = "Student Semestar";
            // 
            // lbdep
            // 
            this.lbdep.AutoSize = true;
            this.lbdep.Location = new System.Drawing.Point(73, 150);
            this.lbdep.Name = "lbdep";
            this.lbdep.Size = new System.Drawing.Size(62, 13);
            this.lbdep.TabIndex = 2;
            this.lbdep.Text = "Department";
            // 
            // lbenroll
            // 
            this.lbenroll.AutoSize = true;
            this.lbenroll.Location = new System.Drawing.Point(73, 101);
            this.lbenroll.Name = "lbenroll";
            this.lbenroll.Size = new System.Drawing.Size(73, 13);
            this.lbenroll.TabIndex = 1;
            this.lbenroll.Text = "Enrollment No";
            this.lbenroll.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbstname
            // 
            this.lbstname.AutoSize = true;
            this.lbstname.Location = new System.Drawing.Point(73, 49);
            this.lbstname.Name = "lbstname";
            this.lbstname.Size = new System.Drawing.Size(75, 13);
            this.lbstname.TabIndex = 0;
            this.lbstname.Text = "Student Name";
            // 
            // View_Student_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(855, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefrsh);
            this.Controls.Add(this.txtsearchinfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "View_Student_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Student_Info";
            this.Load += new System.EventHandler(this.View_Student_Info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsearchinfo;
        private System.Windows.Forms.Button btnRefrsh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbsem;
        private System.Windows.Forms.Label lbdep;
        private System.Windows.Forms.Label lbenroll;
        private System.Windows.Forms.Label lbstname;
        private System.Windows.Forms.Button btncancell;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcon;
        private System.Windows.Forms.TextBox txtsem;
        private System.Windows.Forms.TextBox txtdep;
        private System.Windows.Forms.TextBox txtenno;
        private System.Windows.Forms.TextBox txtstname;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbcon;
    }
}