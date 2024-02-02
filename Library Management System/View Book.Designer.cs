
namespace Library_Management_System
{
    partial class View_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Book));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbViewBooks = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbBookname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBkQua = new System.Windows.Forms.TextBox();
            this.txtBkPrice = new System.Windows.Forms.TextBox();
            this.txtBkPub = new System.Windows.Forms.TextBox();
            this.txtBkAname = new System.Windows.Forms.TextBox();
            this.txtBkname = new System.Windows.Forms.TextBox();
            this.lbBkQua = new System.Windows.Forms.Label();
            this.lbBKPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbBKPub = new System.Windows.Forms.Label();
            this.lbBKAname = new System.Windows.Forms.Label();
            this.lbBKname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbViewBooks);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 116);
            this.panel1.TabIndex = 0;
            // 
            // lbViewBooks
            // 
            this.lbViewBooks.AutoSize = true;
            this.lbViewBooks.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViewBooks.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbViewBooks.Location = new System.Drawing.Point(430, 51);
            this.lbViewBooks.Name = "lbViewBooks";
            this.lbViewBooks.Size = new System.Drawing.Size(129, 29);
            this.lbViewBooks.TabIndex = 2;
            this.lbViewBooks.Text = "View Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(285, 127);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(144, 23);
            this.txtBookName.TabIndex = 4;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(452, 125);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbBookname
            // 
            this.lbBookname.AutoSize = true;
            this.lbBookname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookname.Location = new System.Drawing.Point(200, 127);
            this.lbBookname.Name = "lbBookname";
            this.lbBookname.Size = new System.Drawing.Size(79, 18);
            this.lbBookname.TabIndex = 6;
            this.lbBookname.Text = "Book Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(859, 274);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtdateTimePicker1);
            this.panel2.Controls.Add(this.txtBkQua);
            this.panel2.Controls.Add(this.txtBkPrice);
            this.panel2.Controls.Add(this.txtBkPub);
            this.panel2.Controls.Add(this.txtBkAname);
            this.panel2.Controls.Add(this.txtBkname);
            this.panel2.Controls.Add(this.lbBkQua);
            this.panel2.Controls.Add(this.lbBKPrice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbBKPub);
            this.panel2.Controls.Add(this.lbBKAname);
            this.panel2.Controls.Add(this.lbBKname);
            this.panel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 305);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(689, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Location = new System.Drawing.Point(580, 237);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(469, 237);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtdateTimePicker1
            // 
            this.txtdateTimePicker1.Location = new System.Drawing.Point(562, 47);
            this.txtdateTimePicker1.Name = "txtdateTimePicker1";
            this.txtdateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.txtdateTimePicker1.TabIndex = 11;
            this.txtdateTimePicker1.Value = new System.DateTime(2021, 5, 2, 0, 0, 0, 0);
            this.txtdateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtBkQua
            // 
            this.txtBkQua.Location = new System.Drawing.Point(562, 170);
            this.txtBkQua.Name = "txtBkQua";
            this.txtBkQua.Size = new System.Drawing.Size(205, 23);
            this.txtBkQua.TabIndex = 10;
            this.txtBkQua.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtBkPrice
            // 
            this.txtBkPrice.Location = new System.Drawing.Point(562, 107);
            this.txtBkPrice.Name = "txtBkPrice";
            this.txtBkPrice.Size = new System.Drawing.Size(205, 23);
            this.txtBkPrice.TabIndex = 9;
            this.txtBkPrice.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtBkPub
            // 
            this.txtBkPub.Location = new System.Drawing.Point(197, 170);
            this.txtBkPub.Name = "txtBkPub";
            this.txtBkPub.Size = new System.Drawing.Size(205, 23);
            this.txtBkPub.TabIndex = 8;
            this.txtBkPub.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtBkAname
            // 
            this.txtBkAname.Location = new System.Drawing.Point(197, 107);
            this.txtBkAname.Name = "txtBkAname";
            this.txtBkAname.Size = new System.Drawing.Size(205, 23);
            this.txtBkAname.TabIndex = 7;
            this.txtBkAname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtBkname
            // 
            this.txtBkname.Location = new System.Drawing.Point(197, 50);
            this.txtBkname.Name = "txtBkname";
            this.txtBkname.Size = new System.Drawing.Size(205, 23);
            this.txtBkname.TabIndex = 6;
            this.txtBkname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbBkQua
            // 
            this.lbBkQua.AutoSize = true;
            this.lbBkQua.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBkQua.Location = new System.Drawing.Point(441, 173);
            this.lbBkQua.Name = "lbBkQua";
            this.lbBkQua.Size = new System.Drawing.Size(85, 15);
            this.lbBkQua.TabIndex = 5;
            this.lbBkQua.Text = "Book Quantity";
            this.lbBkQua.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbBKPrice
            // 
            this.lbBKPrice.AutoSize = true;
            this.lbBKPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBKPrice.Location = new System.Drawing.Point(441, 110);
            this.lbBKPrice.Name = "lbBKPrice";
            this.lbBKPrice.Size = new System.Drawing.Size(64, 15);
            this.lbBKPrice.TabIndex = 4;
            this.lbBKPrice.Text = "Book Price";
            this.lbBKPrice.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Purchase Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbBKPub
            // 
            this.lbBKPub.AutoSize = true;
            this.lbBKPub.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBKPub.Location = new System.Drawing.Point(79, 173);
            this.lbBKPub.Name = "lbBKPub";
            this.lbBKPub.Size = new System.Drawing.Size(97, 15);
            this.lbBKPub.TabIndex = 2;
            this.lbBKPub.Text = "Book Publication";
            this.lbBKPub.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbBKAname
            // 
            this.lbBKAname.AutoSize = true;
            this.lbBKAname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBKAname.Location = new System.Drawing.Point(79, 110);
            this.lbBKAname.Name = "lbBKAname";
            this.lbBKAname.Size = new System.Drawing.Size(112, 15);
            this.lbBKAname.TabIndex = 1;
            this.lbBKAname.Text = "Book Author Name";
            this.lbBKAname.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbBKname
            // 
            this.lbBKname.AutoSize = true;
            this.lbBKname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBKname.Location = new System.Drawing.Point(79, 53);
            this.lbBKname.Name = "lbBKname";
            this.lbBKname.Size = new System.Drawing.Size(70, 15);
            this.lbBKname.TabIndex = 0;
            this.lbBKname.Text = "Book Name";
            this.lbBKname.Click += new System.EventHandler(this.label1_Click);
            // 
            // View_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(860, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbBookname);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.panel1);
            this.Name = "View_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Book";
            this.Load += new System.EventHandler(this.View_Book_Load);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbViewBooks;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbBookname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker txtdateTimePicker1;
        private System.Windows.Forms.TextBox txtBkQua;
        private System.Windows.Forms.TextBox txtBkPrice;
        private System.Windows.Forms.TextBox txtBkPub;
        private System.Windows.Forms.TextBox txtBkAname;
        private System.Windows.Forms.TextBox txtBkname;
        private System.Windows.Forms.Label lbBkQua;
        private System.Windows.Forms.Label lbBKPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbBKPub;
        private System.Windows.Forms.Label lbBKAname;
        private System.Windows.Forms.Label lbBKname;
    }
}