namespace ICT_PROJECT_E2140154
{
    partial class DMReports
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvOrderManagement = new System.Windows.Forms.DataGridView();
            this.OderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPerItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderManagement)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.dgvOrderManagement);
            this.panel2.Location = new System.Drawing.Point(23, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1339, 341);
            this.panel2.TabIndex = 127;
            // 
            // dgvOrderManagement
            // 
            this.dgvOrderManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OderNumber,
            this.OderDate,
            this.Item_code,
            this.Item_name,
            this.Item_category,
            this.Item_price,
            this.Item_quantity,
            this.DiscountPerItem,
            this.TotalDiscount,
            this.TotalAmount});
            this.dgvOrderManagement.Location = new System.Drawing.Point(15, 29);
            this.dgvOrderManagement.Name = "dgvOrderManagement";
            this.dgvOrderManagement.RowHeadersWidth = 51;
            this.dgvOrderManagement.RowTemplate.Height = 24;
            this.dgvOrderManagement.Size = new System.Drawing.Size(1312, 275);
            this.dgvOrderManagement.TabIndex = 112;
            // 
            // OderNumber
            // 
            this.OderNumber.DataPropertyName = "OderNumber";
            this.OderNumber.HeaderText = "Oder Number";
            this.OderNumber.MinimumWidth = 6;
            this.OderNumber.Name = "OderNumber";
            this.OderNumber.Width = 125;
            // 
            // OderDate
            // 
            this.OderDate.DataPropertyName = "OderDate";
            this.OderDate.HeaderText = "Oder Date";
            this.OderDate.MinimumWidth = 6;
            this.OderDate.Name = "OderDate";
            this.OderDate.Width = 125;
            // 
            // Item_code
            // 
            this.Item_code.DataPropertyName = "ItemCode";
            this.Item_code.HeaderText = "Item Code";
            this.Item_code.MinimumWidth = 6;
            this.Item_code.Name = "Item_code";
            this.Item_code.Width = 125;
            // 
            // Item_name
            // 
            this.Item_name.DataPropertyName = "ItemName";
            this.Item_name.HeaderText = "Item Name";
            this.Item_name.MinimumWidth = 6;
            this.Item_name.Name = "Item_name";
            this.Item_name.Width = 125;
            // 
            // Item_category
            // 
            this.Item_category.DataPropertyName = "CategoryName";
            this.Item_category.HeaderText = "Item Category";
            this.Item_category.MinimumWidth = 6;
            this.Item_category.Name = "Item_category";
            this.Item_category.Width = 125;
            // 
            // Item_price
            // 
            this.Item_price.DataPropertyName = "ItemPrice";
            this.Item_price.HeaderText = "Item Price";
            this.Item_price.MinimumWidth = 6;
            this.Item_price.Name = "Item_price";
            this.Item_price.Width = 125;
            // 
            // Item_quantity
            // 
            this.Item_quantity.DataPropertyName = "ItemQuantity";
            this.Item_quantity.HeaderText = "Item Quantity";
            this.Item_quantity.MinimumWidth = 6;
            this.Item_quantity.Name = "Item_quantity";
            this.Item_quantity.Width = 125;
            // 
            // DiscountPerItem
            // 
            this.DiscountPerItem.DataPropertyName = "ItemDiscount";
            this.DiscountPerItem.HeaderText = "Discount Per Item (Rs.)";
            this.DiscountPerItem.MinimumWidth = 6;
            this.DiscountPerItem.Name = "DiscountPerItem";
            this.DiscountPerItem.Width = 125;
            // 
            // TotalDiscount
            // 
            this.TotalDiscount.DataPropertyName = "DiscountAmount";
            this.TotalDiscount.HeaderText = "Total Discount (Rs.)";
            this.TotalDiscount.MinimumWidth = 6;
            this.TotalDiscount.Name = "TotalDiscount";
            this.TotalDiscount.Width = 125;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "Ttotal";
            this.TotalAmount.HeaderText = "Total Amount (Rs.)";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1132, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 32);
            this.label9.TabIndex = 52;
            this.label9.Text = "DM REPORTS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sylfaen", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 171);
            this.label10.TabIndex = 19;
            this.label10.Text = "BUBBLE \r\nTEA \r\nSHOP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(1336, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 50);
            this.label11.TabIndex = 17;
            this.label11.Text = "X\r\n\r\n";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(-1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1379, 179);
            this.panel6.TabIndex = 125;
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
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(53, 172);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(124, 41);
            this.btnRefresh.TabIndex = 107;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(53, 123);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 41);
            this.btnSearch.TabIndex = 106;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(449, 53);
            this.dtTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(270, 22);
            this.dtTo.TabIndex = 105;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(53, 53);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(270, 22);
            this.dtFrom.TabIndex = 104;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(27, 812);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 41);
            this.btnBack.TabIndex = 124;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(447, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 110;
            this.label3.Text = "To :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 109;
            this.label4.Text = "From :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(4, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 23);
            this.label5.TabIndex = 103;
            this.label5.Text = "Daily / Monthly Revenue :";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRevenue.Location = new System.Drawing.Point(8, 43);
            this.lblRevenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(178, 23);
            this.lblRevenue.TabIndex = 102;
            this.lblRevenue.Text = "------------------------";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dtTo);
            this.panel1.Controls.Add(this.dtFrom);
            this.panel1.Location = new System.Drawing.Point(23, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 242);
            this.panel1.TabIndex = 126;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblRevenue);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(451, 114);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 82);
            this.panel3.TabIndex = 111;
            // 
            // DMReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 870);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DMReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMReports";
            this.Load += new System.EventHandler(this.DMReports_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderManagement)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvOrderManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn OderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPerItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}