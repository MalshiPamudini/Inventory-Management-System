namespace ICT_PROJECT_E2140154
{
    partial class bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bill));
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPrintBill = new System.Windows.Forms.Button();
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
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvItemManagement = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSelectCategory = new System.Windows.Forms.ComboBox();
            this.txtItmCode = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtItmQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItmPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItmCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItmName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderManagement)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemManagement)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Item Code";
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.btnView);
            this.panel5.Controls.Add(this.btnPrintBill);
            this.panel5.Controls.Add(this.dgvOrderManagement);
            this.panel5.Controls.Add(this.lblTotalAmount);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(760, 333);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(570, 508);
            this.panel5.TabIndex = 61;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnView.Location = new System.Drawing.Point(400, 454);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(156, 40);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "VIEW ALL SALES";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BackColor = System.Drawing.Color.White;
            this.btnPrintBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrintBill.Location = new System.Drawing.Point(400, 399);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(145, 40);
            this.btnPrintBill.TabIndex = 13;
            this.btnPrintBill.Text = "PRINT BILL";
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
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
            this.dgvOrderManagement.Location = new System.Drawing.Point(31, 19);
            this.dgvOrderManagement.Name = "dgvOrderManagement";
            this.dgvOrderManagement.RowHeadersWidth = 51;
            this.dgvOrderManagement.RowTemplate.Height = 24;
            this.dgvOrderManagement.Size = new System.Drawing.Size(509, 311);
            this.dgvOrderManagement.TabIndex = 1;
            this.dgvOrderManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderManagement_CellClick);
            this.dgvOrderManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderManagement_CellContentClick);
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
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location = new System.Drawing.Point(38, 399);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(122, 23);
            this.lblTotalAmount.TabIndex = 12;
            this.lblTotalAmount.Text = "----------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "TOTAL AMOUNT :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.btnHome);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnNew);
            this.panel4.Location = new System.Drawing.Point(17, 751);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(723, 90);
            this.panel4.TabIndex = 60;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.Location = new System.Drawing.Point(577, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(108, 42);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(444, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 42);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(306, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 42);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(168, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 42);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnNew.Location = new System.Drawing.Point(29, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(108, 42);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(4, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1350, 179);
            this.panel6.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ICT_PROJECT_E2140154.Properties.Resources._360_F_431056131_Pp493cTNa08pc0FNv45JR3P8cmD3RKGg___Copy;
            this.pictureBox1.Location = new System.Drawing.Point(139, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1116, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 32);
            this.label9.TabIndex = 52;
            this.label9.Text = "BILL PREPARE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(1308, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 50);
            this.label11.TabIndex = 17;
            this.label11.Text = "X\r\n\r\n";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.dtOrderDate);
            this.panel1.Controls.Add(this.txtOrderNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(760, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 106);
            this.panel1.TabIndex = 57;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Location = new System.Drawing.Point(230, 59);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(241, 22);
            this.dtOrderDate.TabIndex = 7;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(32, 59);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(100, 22);
            this.txtOrderNumber.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(226, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Order Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Order Number ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.dgvItemManagement);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.cmbSelectCategory);
            this.panel2.Location = new System.Drawing.Point(17, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 379);
            this.panel2.TabIndex = 58;
            // 
            // dgvItemManagement
            // 
            this.dgvItemManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.ItemPrice,
            this.ItemCategory,
            this.DiscountAmount});
            this.dgvItemManagement.Location = new System.Drawing.Point(29, 88);
            this.dgvItemManagement.Name = "dgvItemManagement";
            this.dgvItemManagement.RowHeadersWidth = 51;
            this.dgvItemManagement.RowTemplate.Height = 24;
            this.dgvItemManagement.Size = new System.Drawing.Size(679, 265);
            this.dgvItemManagement.TabIndex = 7;
            this.dgvItemManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemManagement_CellClick);
            this.dgvItemManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemManagement_CellContentClick);
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "item_code";
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Width = 125;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "item_name";
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 125;
            // 
            // ItemPrice
            // 
            this.ItemPrice.DataPropertyName = "item_price";
            this.ItemPrice.HeaderText = "Item Price (Rs.)";
            this.ItemPrice.MinimumWidth = 6;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Width = 125;
            // 
            // ItemCategory
            // 
            this.ItemCategory.DataPropertyName = "item_category";
            this.ItemCategory.HeaderText = "Item Category";
            this.ItemCategory.MinimumWidth = 6;
            this.ItemCategory.Name = "ItemCategory";
            this.ItemCategory.Width = 125;
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.DataPropertyName = "item_discount";
            this.DiscountAmount.HeaderText = "Discount Amount (Rs.)";
            this.DiscountAmount.MinimumWidth = 6;
            this.DiscountAmount.Name = "DiscountAmount";
            this.DiscountAmount.Width = 125;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(454, 34);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 32);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(251, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSelectCategory
            // 
            this.cmbSelectCategory.FormattingEnabled = true;
            this.cmbSelectCategory.Location = new System.Drawing.Point(29, 42);
            this.cmbSelectCategory.Name = "cmbSelectCategory";
            this.cmbSelectCategory.Size = new System.Drawing.Size(186, 24);
            this.cmbSelectCategory.TabIndex = 4;
            // 
            // txtItmCode
            // 
            this.txtItmCode.Location = new System.Drawing.Point(33, 43);
            this.txtItmCode.Name = "txtItmCode";
            this.txtItmCode.Size = new System.Drawing.Size(208, 22);
            this.txtItmCode.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.txtItmQuantity);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtItmPrice);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtItmCategory);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtItmName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtItmCode);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(17, 599);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 140);
            this.panel3.TabIndex = 59;
            // 
            // txtItmQuantity
            // 
            this.txtItmQuantity.Location = new System.Drawing.Point(534, 43);
            this.txtItmQuantity.Name = "txtItmQuantity";
            this.txtItmQuantity.Size = new System.Drawing.Size(167, 22);
            this.txtItmQuantity.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(530, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Item Quantity";
            // 
            // txtItmPrice
            // 
            this.txtItmPrice.Location = new System.Drawing.Point(277, 103);
            this.txtItmPrice.Name = "txtItmPrice";
            this.txtItmPrice.Size = new System.Drawing.Size(208, 22);
            this.txtItmPrice.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(278, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Item Price";
            // 
            // txtItmCategory
            // 
            this.txtItmCategory.Location = new System.Drawing.Point(268, 43);
            this.txtItmCategory.Name = "txtItmCategory";
            this.txtItmCategory.Size = new System.Drawing.Size(208, 22);
            this.txtItmCategory.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(273, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Item Category";
            // 
            // txtItmName
            // 
            this.txtItmName.Location = new System.Drawing.Point(33, 103);
            this.txtItmName.Name = "txtItmName";
            this.txtItmName.Size = new System.Drawing.Size(208, 22);
            this.txtItmName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Item Name";
            // 
            // bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 852);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.bill_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderManagement)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemManagement)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPrintBill;
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
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvItemManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountAmount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSelectCategory;
        private System.Windows.Forms.TextBox txtItmCode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtItmQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItmPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItmCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItmName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}