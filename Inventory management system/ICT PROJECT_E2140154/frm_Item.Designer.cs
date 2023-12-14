namespace ICT_PROJECT_E2140154
{
    partial class frm_Item
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
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSelectCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbItemCategory = new System.Windows.Forms.ComboBox();
            this.txt_disc = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_iname = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ihome = new System.Windows.Forms.Button();
            this.btn_idelete = new System.Windows.Forms.Button();
            this.btn_iedit = new System.Windows.Forms.Button();
            this.btn_Iadd = new System.Windows.Forms.Button();
            this.btn_Inew = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.dgv_item);
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.cmbSelectCategory);
            this.panel4.Location = new System.Drawing.Point(28, 395);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1045, 450);
            this.panel4.TabIndex = 61;
            // 
            // dgv_item
            // 
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.ItemPrice,
            this.ItemCategory,
            this.DiscountAmount});
            this.dgv_item.Location = new System.Drawing.Point(122, 80);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.RowHeadersWidth = 51;
            this.dgv_item.RowTemplate.Height = 24;
            this.dgv_item.Size = new System.Drawing.Size(835, 336);
            this.dgv_item.TabIndex = 19;
            this.dgv_item.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_item_CellClick);
            this.dgv_item.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_item_CellContentClick);
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "item_code";
            this.ItemCode.HeaderText = "ITEM CODE";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Width = 125;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "item_name";
            this.ItemName.HeaderText = "ITEM NAME";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 125;
            // 
            // ItemPrice
            // 
            this.ItemPrice.DataPropertyName = "item_price";
            this.ItemPrice.HeaderText = "ITEM PRICE";
            this.ItemPrice.MinimumWidth = 6;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Width = 125;
            // 
            // ItemCategory
            // 
            this.ItemCategory.DataPropertyName = "item_category";
            this.ItemCategory.HeaderText = "ITEM CATEGORY";
            this.ItemCategory.MinimumWidth = 6;
            this.ItemCategory.Name = "ItemCategory";
            this.ItemCategory.Width = 125;
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.DataPropertyName = "item_discount";
            this.DiscountAmount.HeaderText = "DISCOUNT AMOUNT";
            this.DiscountAmount.MinimumWidth = 6;
            this.DiscountAmount.Name = "DiscountAmount";
            this.DiscountAmount.Width = 125;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(678, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(164, 33);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(512, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 33);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSelectCategory
            // 
            this.cmbSelectCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cmbSelectCategory.FormattingEnabled = true;
            this.cmbSelectCategory.Location = new System.Drawing.Point(218, 26);
            this.cmbSelectCategory.Name = "cmbSelectCategory";
            this.cmbSelectCategory.Size = new System.Drawing.Size(253, 31);
            this.cmbSelectCategory.TabIndex = 16;
            this.cmbSelectCategory.Text = "SELECT CATEGORY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(769, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 32);
            this.label7.TabIndex = 53;
            this.label7.Text = "ITEM MANAGEMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 171);
            this.label2.TabIndex = 19;
            this.label2.Text = "BUBBLE \r\nTEA \r\nSHOP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(1068, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 50);
            this.label6.TabIndex = 17;
            this.label6.Text = "X\r\n\r\n";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 179);
            this.panel2.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ICT_PROJECT_E2140154.Properties.Resources._360_F_431056131_Pp493cTNa08pc0FNv45JR3P8cmD3RKGg___Copy;
            this.pictureBox1.Location = new System.Drawing.Point(150, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.cmbItemCategory);
            this.panel1.Controls.Add(this.txt_disc);
            this.panel1.Controls.Add(this.txt_price);
            this.panel1.Controls.Add(this.txt_iname);
            this.panel1.Controls.Add(this.txt_code);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 170);
            this.panel1.TabIndex = 58;
            // 
            // cmbItemCategory
            // 
            this.cmbItemCategory.FormattingEnabled = true;
            this.cmbItemCategory.Location = new System.Drawing.Point(477, 76);
            this.cmbItemCategory.Name = "cmbItemCategory";
            this.cmbItemCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbItemCategory.TabIndex = 10;
            // 
            // txt_disc
            // 
            this.txt_disc.Location = new System.Drawing.Point(231, 126);
            this.txt_disc.Name = "txt_disc";
            this.txt_disc.Size = new System.Drawing.Size(100, 22);
            this.txt_disc.TabIndex = 9;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(154, 76);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 22);
            this.txt_price.TabIndex = 7;
            // 
            // txt_iname
            // 
            this.txt_iname.Location = new System.Drawing.Point(440, 29);
            this.txt_iname.Name = "txt_iname";
            this.txt_iname.Size = new System.Drawing.Size(100, 22);
            this.txt_iname.TabIndex = 6;
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(154, 31);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(100, 22);
            this.txt_code.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "DISCOUNT AMOUNT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(294, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "ITEM CATEGORY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ITEM PRICE";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(294, 29);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(125, 23);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "ITEM NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM CODE";
            // 
            // btn_ihome
            // 
            this.btn_ihome.BackColor = System.Drawing.Color.White;
            this.btn_ihome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ihome.Location = new System.Drawing.Point(161, 89);
            this.btn_ihome.Name = "btn_ihome";
            this.btn_ihome.Size = new System.Drawing.Size(104, 40);
            this.btn_ihome.TabIndex = 15;
            this.btn_ihome.Text = "HOME";
            this.btn_ihome.UseVisualStyleBackColor = false;
            this.btn_ihome.Click += new System.EventHandler(this.btn_ihome_Click);
            // 
            // btn_idelete
            // 
            this.btn_idelete.BackColor = System.Drawing.Color.White;
            this.btn_idelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_idelete.Location = new System.Drawing.Point(7, 89);
            this.btn_idelete.Name = "btn_idelete";
            this.btn_idelete.Size = new System.Drawing.Size(133, 40);
            this.btn_idelete.TabIndex = 14;
            this.btn_idelete.Text = "DELETE";
            this.btn_idelete.UseVisualStyleBackColor = false;
            this.btn_idelete.Click += new System.EventHandler(this.btn_idelete_Click);
            // 
            // btn_iedit
            // 
            this.btn_iedit.BackColor = System.Drawing.Color.White;
            this.btn_iedit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_iedit.Location = new System.Drawing.Point(239, 29);
            this.btn_iedit.Name = "btn_iedit";
            this.btn_iedit.Size = new System.Drawing.Size(84, 39);
            this.btn_iedit.TabIndex = 13;
            this.btn_iedit.Text = "EDIT";
            this.btn_iedit.UseVisualStyleBackColor = false;
            this.btn_iedit.Click += new System.EventHandler(this.btn_iedit_Click);
            // 
            // btn_Iadd
            // 
            this.btn_Iadd.BackColor = System.Drawing.Color.White;
            this.btn_Iadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Iadd.Location = new System.Drawing.Point(124, 29);
            this.btn_Iadd.Name = "btn_Iadd";
            this.btn_Iadd.Size = new System.Drawing.Size(84, 39);
            this.btn_Iadd.TabIndex = 12;
            this.btn_Iadd.Text = "ADD";
            this.btn_Iadd.UseVisualStyleBackColor = false;
            this.btn_Iadd.Click += new System.EventHandler(this.btn_Iadd_Click);
            // 
            // btn_Inew
            // 
            this.btn_Inew.BackColor = System.Drawing.Color.White;
            this.btn_Inew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Inew.Location = new System.Drawing.Point(7, 30);
            this.btn_Inew.Name = "btn_Inew";
            this.btn_Inew.Size = new System.Drawing.Size(84, 39);
            this.btn_Inew.TabIndex = 11;
            this.btn_Inew.Text = "NEW";
            this.btn_Inew.UseVisualStyleBackColor = false;
            this.btn_Inew.Click += new System.EventHandler(this.btn_Inew_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.btn_ihome);
            this.panel3.Controls.Add(this.btn_idelete);
            this.panel3.Controls.Add(this.btn_iedit);
            this.panel3.Controls.Add(this.btn_Iadd);
            this.panel3.Controls.Add(this.btn_Inew);
            this.panel3.Location = new System.Drawing.Point(679, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 170);
            this.panel3.TabIndex = 60;
            // 
            // frm_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 855);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Item";
            this.Load += new System.EventHandler(this.frm_Item_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountAmount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSelectCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbItemCategory;
        private System.Windows.Forms.TextBox txt_disc;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_iname;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ihome;
        private System.Windows.Forms.Button btn_idelete;
        private System.Windows.Forms.Button btn_iedit;
        private System.Windows.Forms.Button btn_Iadd;
        private System.Windows.Forms.Button btn_Inew;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}