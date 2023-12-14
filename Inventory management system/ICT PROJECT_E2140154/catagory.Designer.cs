namespace ICT_PROJECT_E2140154
{
    partial class catagory
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_cat = new System.Windows.Forms.DataGridView();
            this.Cat_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cat_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Cname = new System.Windows.Forms.TextBox();
            this.txt_Ccode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Chome = new System.Windows.Forms.Button();
            this.btn_Cdele = new System.Windows.Forms.Button();
            this.btn_Cedit = new System.Windows.Forms.Button();
            this.btn_Cadd = new System.Windows.Forms.Button();
            this.btn_Cnew = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cat)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.dgv_cat);
            this.panel4.Location = new System.Drawing.Point(296, 206);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(407, 335);
            this.panel4.TabIndex = 61;
            // 
            // dgv_cat
            // 
            this.dgv_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cat_Code,
            this.Cat_Name});
            this.dgv_cat.Location = new System.Drawing.Point(24, 9);
            this.dgv_cat.Name = "dgv_cat";
            this.dgv_cat.RowHeadersWidth = 51;
            this.dgv_cat.RowTemplate.Height = 24;
            this.dgv_cat.Size = new System.Drawing.Size(357, 309);
            this.dgv_cat.TabIndex = 9;
            this.dgv_cat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cat_CellClick);
            this.dgv_cat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cat_CellContentClick);
            // 
            // Cat_Code
            // 
            this.Cat_Code.DataPropertyName = "Cat_code";
            this.Cat_Code.HeaderText = "Category Coede";
            this.Cat_Code.MinimumWidth = 6;
            this.Cat_Code.Name = "Cat_Code";
            this.Cat_Code.Width = 125;
            // 
            // Cat_Name
            // 
            this.Cat_Name.DataPropertyName = "Cat_name";
            this.Cat_Name.HeaderText = "Category Name";
            this.Cat_Name.MinimumWidth = 6;
            this.Cat_Name.Name = "Cat_Name";
            this.Cat_Name.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.txt_Cname);
            this.panel1.Controls.Add(this.txt_Ccode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 137);
            this.panel1.TabIndex = 59;
            // 
            // txt_Cname
            // 
            this.txt_Cname.Location = new System.Drawing.Point(12, 91);
            this.txt_Cname.Name = "txt_Cname";
            this.txt_Cname.Size = new System.Drawing.Size(181, 22);
            this.txt_Cname.TabIndex = 3;
            // 
            // txt_Ccode
            // 
            this.txt_Ccode.Location = new System.Drawing.Point(12, 33);
            this.txt_Ccode.Name = "txt_Ccode";
            this.txt_Ccode.Size = new System.Drawing.Size(181, 22);
            this.txt_Ccode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = " Category Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(312, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 32);
            this.label5.TabIndex = 52;
            this.label5.Text = "CATEGORY MANAGEMENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 171);
            this.label3.TabIndex = 19;
            this.label3.Text = "BUBBLE \r\nTEA \r\nSHOP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(673, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 50);
            this.label4.TabIndex = 17;
            this.label4.Text = "X\r\n\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_Chome
            // 
            this.btn_Chome.BackColor = System.Drawing.Color.White;
            this.btn_Chome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Chome.Location = new System.Drawing.Point(94, 76);
            this.btn_Chome.Name = "btn_Chome";
            this.btn_Chome.Size = new System.Drawing.Size(90, 32);
            this.btn_Chome.TabIndex = 8;
            this.btn_Chome.Text = "HOME";
            this.btn_Chome.UseVisualStyleBackColor = false;
            this.btn_Chome.Click += new System.EventHandler(this.btn_Chome_Click);
            // 
            // btn_Cdele
            // 
            this.btn_Cdele.BackColor = System.Drawing.Color.White;
            this.btn_Cdele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Cdele.Location = new System.Drawing.Point(4, 131);
            this.btn_Cdele.Name = "btn_Cdele";
            this.btn_Cdele.Size = new System.Drawing.Size(111, 34);
            this.btn_Cdele.TabIndex = 7;
            this.btn_Cdele.Text = "DELETE";
            this.btn_Cdele.UseVisualStyleBackColor = false;
            this.btn_Cdele.Click += new System.EventHandler(this.btn_Cdele_Click);
            // 
            // btn_Cedit
            // 
            this.btn_Cedit.BackColor = System.Drawing.Color.White;
            this.btn_Cedit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Cedit.Location = new System.Drawing.Point(4, 76);
            this.btn_Cedit.Name = "btn_Cedit";
            this.btn_Cedit.Size = new System.Drawing.Size(75, 34);
            this.btn_Cedit.TabIndex = 6;
            this.btn_Cedit.Text = "EDIT";
            this.btn_Cedit.UseVisualStyleBackColor = false;
            this.btn_Cedit.Click += new System.EventHandler(this.btn_Cedit_Click);
            // 
            // btn_Cadd
            // 
            this.btn_Cadd.BackColor = System.Drawing.Color.White;
            this.btn_Cadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Cadd.Location = new System.Drawing.Point(107, 23);
            this.btn_Cadd.Name = "btn_Cadd";
            this.btn_Cadd.Size = new System.Drawing.Size(75, 36);
            this.btn_Cadd.TabIndex = 5;
            this.btn_Cadd.Text = "ADD";
            this.btn_Cadd.UseVisualStyleBackColor = false;
            this.btn_Cadd.Click += new System.EventHandler(this.btn_Cadd_Click);
            // 
            // btn_Cnew
            // 
            this.btn_Cnew.BackColor = System.Drawing.Color.White;
            this.btn_Cnew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Cnew.Location = new System.Drawing.Point(4, 23);
            this.btn_Cnew.Name = "btn_Cnew";
            this.btn_Cnew.Size = new System.Drawing.Size(75, 36);
            this.btn_Cnew.TabIndex = 4;
            this.btn_Cnew.Text = "NEW";
            this.btn_Cnew.UseVisualStyleBackColor = false;
            this.btn_Cnew.Click += new System.EventHandler(this.btn_Cnew_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.btn_Chome);
            this.panel3.Controls.Add(this.btn_Cdele);
            this.panel3.Controls.Add(this.btn_Cedit);
            this.panel3.Controls.Add(this.btn_Cadd);
            this.panel3.Controls.Add(this.btn_Cnew);
            this.panel3.Location = new System.Drawing.Point(25, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 182);
            this.panel3.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 179);
            this.panel2.TabIndex = 58;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ICT_PROJECT_E2140154.Properties.Resources._360_F_431056131_Pp493cTNa08pc0FNv45JR3P8cmD3RKGg___Copy;
            this.pictureBox1.Location = new System.Drawing.Point(156, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // catagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 573);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "catagory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "catagory";
            this.Load += new System.EventHandler(this.catagory_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Cname;
        private System.Windows.Forms.TextBox txt_Ccode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Chome;
        private System.Windows.Forms.Button btn_Cdele;
        private System.Windows.Forms.Button btn_Cedit;
        private System.Windows.Forms.Button btn_Cadd;
        private System.Windows.Forms.Button btn_Cnew;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}