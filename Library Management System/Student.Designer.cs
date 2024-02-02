
namespace Library_Management_System
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStcon = new System.Windows.Forms.TextBox();
            this.txtStsem = new System.Windows.Forms.TextBox();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.txtEno = new System.Windows.Forms.TextBox();
            this.txtstname = new System.Windows.Forms.TextBox();
            this.lbstEmail = new System.Windows.Forms.Label();
            this.lbstcon = new System.Windows.Forms.Label();
            this.lbstsem = new System.Windows.Forms.Label();
            this.lbDep = new System.Windows.Forms.Label();
            this.lbEno = new System.Windows.Forms.Label();
            this.lbstname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 101);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Student";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 330);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtStcon);
            this.panel2.Controls.Add(this.txtStsem);
            this.panel2.Controls.Add(this.txtDep);
            this.panel2.Controls.Add(this.txtEno);
            this.panel2.Controls.Add(this.txtstname);
            this.panel2.Controls.Add(this.lbstEmail);
            this.panel2.Controls.Add(this.lbstcon);
            this.panel2.Controls.Add(this.lbstsem);
            this.panel2.Controls.Add(this.lbDep);
            this.panel2.Controls.Add(this.lbEno);
            this.panel2.Controls.Add(this.lbstname);
            this.panel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(251, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 330);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(294, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(191, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save Info";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(86, 294);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(191, 234);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 23);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtStcon
            // 
            this.txtStcon.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStcon.Location = new System.Drawing.Point(191, 188);
            this.txtStcon.Name = "txtStcon";
            this.txtStcon.Size = new System.Drawing.Size(207, 23);
            this.txtStcon.TabIndex = 10;
            this.txtStcon.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtStsem
            // 
            this.txtStsem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStsem.Location = new System.Drawing.Point(191, 147);
            this.txtStsem.Name = "txtStsem";
            this.txtStsem.Size = new System.Drawing.Size(207, 23);
            this.txtStsem.TabIndex = 9;
            this.txtStsem.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtDep
            // 
            this.txtDep.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDep.Location = new System.Drawing.Point(191, 99);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(207, 23);
            this.txtDep.TabIndex = 8;
            this.txtDep.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEno
            // 
            this.txtEno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEno.Location = new System.Drawing.Point(191, 54);
            this.txtEno.Name = "txtEno";
            this.txtEno.Size = new System.Drawing.Size(207, 23);
            this.txtEno.TabIndex = 7;
            this.txtEno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtstname
            // 
            this.txtstname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstname.Location = new System.Drawing.Point(191, 15);
            this.txtstname.Name = "txtstname";
            this.txtstname.Size = new System.Drawing.Size(207, 23);
            this.txtstname.TabIndex = 6;
            // 
            // lbstEmail
            // 
            this.lbstEmail.AutoSize = true;
            this.lbstEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstEmail.Location = new System.Drawing.Point(29, 242);
            this.lbstEmail.Name = "lbstEmail";
            this.lbstEmail.Size = new System.Drawing.Size(94, 18);
            this.lbstEmail.TabIndex = 5;
            this.lbstEmail.Text = "Student Email";
            this.lbstEmail.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbstcon
            // 
            this.lbstcon.AutoSize = true;
            this.lbstcon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstcon.Location = new System.Drawing.Point(29, 196);
            this.lbstcon.Name = "lbstcon";
            this.lbstcon.Size = new System.Drawing.Size(107, 18);
            this.lbstcon.TabIndex = 4;
            this.lbstcon.Text = "Student Contact";
            this.lbstcon.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbstsem
            // 
            this.lbstsem.AutoSize = true;
            this.lbstsem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstsem.Location = new System.Drawing.Point(29, 155);
            this.lbstsem.Name = "lbstsem";
            this.lbstsem.Size = new System.Drawing.Size(119, 18);
            this.lbstsem.TabIndex = 3;
            this.lbstsem.Text = "Student Semester";
            this.lbstsem.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbDep
            // 
            this.lbDep.AutoSize = true;
            this.lbDep.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDep.Location = new System.Drawing.Point(29, 107);
            this.lbDep.Name = "lbDep";
            this.lbDep.Size = new System.Drawing.Size(83, 18);
            this.lbDep.TabIndex = 2;
            this.lbDep.Text = "Department";
            this.lbDep.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbEno
            // 
            this.lbEno.AutoSize = true;
            this.lbEno.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEno.Location = new System.Drawing.Point(29, 62);
            this.lbEno.Name = "lbEno";
            this.lbEno.Size = new System.Drawing.Size(98, 18);
            this.lbEno.TabIndex = 1;
            this.lbEno.Text = "Enrollment No";
            this.lbEno.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbstname
            // 
            this.lbstname.AutoSize = true;
            this.lbstname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstname.Location = new System.Drawing.Point(29, 23);
            this.lbstname.Name = "lbstname";
            this.lbstname.Size = new System.Drawing.Size(97, 18);
            this.lbstname.TabIndex = 0;
            this.lbstname.Text = "Student Name";
            this.lbstname.Click += new System.EventHandler(this.label2_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbstname;
        private System.Windows.Forms.Label lbstEmail;
        private System.Windows.Forms.Label lbstcon;
        private System.Windows.Forms.Label lbstsem;
        private System.Windows.Forms.Label lbDep;
        private System.Windows.Forms.Label lbEno;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtStcon;
        private System.Windows.Forms.TextBox txtStsem;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.TextBox txtEno;
        private System.Windows.Forms.TextBox txtstname;
    }
}