﻿namespace Hardware_Syst
{
    partial class frmProcessSale
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
            this.btnRegesterSale = new System.Windows.Forms.Button();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.txtSrh = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSaleID = new System.Windows.Forms.Label();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.btnSrh = new System.Windows.Forms.Button();
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grdStock = new System.Windows.Forms.DataGridView();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAmountOfItems = new System.Windows.Forms.Label();
            this.txtQtySold = new System.Windows.Forms.TextBox();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaleValue = new System.Windows.Forms.TextBox();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.grpPay = new System.Windows.Forms.GroupBox();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.rdoCredit = new System.Windows.Forms.RadioButton();
            this.grpCredit = new System.Windows.Forms.GroupBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.grdCust = new System.Windows.Forms.DataGridView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblforename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.grpStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).BeginInit();
            this.grpCart.SuspendLayout();
            this.grpPay.SuspendLayout();
            this.grpCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCust)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegesterSale
            // 
            this.btnRegesterSale.Location = new System.Drawing.Point(606, 528);
            this.btnRegesterSale.Name = "btnRegesterSale";
            this.btnRegesterSale.Size = new System.Drawing.Size(123, 23);
            this.btnRegesterSale.TabIndex = 21;
            this.btnRegesterSale.Text = "Register Sale";
            this.btnRegesterSale.UseVisualStyleBackColor = true;
            this.btnRegesterSale.Visible = false;
            this.btnRegesterSale.Click += new System.EventHandler(this.btnRegesterSale_Click);
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Location = new System.Drawing.Point(16, 69);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(72, 13);
            this.lblSaleDate.TabIndex = 16;
            this.lblSaleDate.Text = "Search Stock";
            // 
            // txtSrh
            // 
            this.txtSrh.Location = new System.Drawing.Point(94, 66);
            this.txtSrh.Name = "txtSrh";
            this.txtSrh.Size = new System.Drawing.Size(142, 20);
            this.txtSrh.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // lblSaleID
            // 
            this.lblSaleID.AutoSize = true;
            this.lblSaleID.Location = new System.Drawing.Point(16, 30);
            this.lblSaleID.Name = "lblSaleID";
            this.lblSaleID.Size = new System.Drawing.Size(42, 13);
            this.lblSaleID.TabIndex = 39;
            this.lblSaleID.Text = "Sale ID";
            // 
            // txtSaleID
            // 
            this.txtSaleID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSaleID.Location = new System.Drawing.Point(64, 23);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.ReadOnly = true;
            this.txtSaleID.Size = new System.Drawing.Size(35, 20);
            this.txtSaleID.TabIndex = 38;
            this.txtSaleID.Text = "001";
            this.txtSaleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSrh
            // 
            this.btnSrh.Location = new System.Drawing.Point(251, 61);
            this.btnSrh.Name = "btnSrh";
            this.btnSrh.Size = new System.Drawing.Size(58, 29);
            this.btnSrh.TabIndex = 41;
            this.btnSrh.Text = "Search";
            this.btnSrh.UseVisualStyleBackColor = true;
            this.btnSrh.Click += new System.EventHandler(this.btnSrh_Click);
            // 
            // grpStock
            // 
            this.grpStock.Controls.Add(this.btnAdd);
            this.grpStock.Controls.Add(this.grdStock);
            this.grpStock.Controls.Add(this.lblAmountOfItems);
            this.grpStock.Controls.Add(this.txtQtySold);
            this.grpStock.Location = new System.Drawing.Point(31, 115);
            this.grpStock.Name = "grpStock";
            this.grpStock.Size = new System.Drawing.Size(446, 192);
            this.grpStock.TabIndex = 43;
            this.grpStock.TabStop = false;
            this.grpStock.Text = "Stock";
            this.grpStock.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(181, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 24);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grdStock
            // 
            this.grdStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.StockName,
            this.SaleP,
            this.Qty});
            this.grdStock.Location = new System.Drawing.Point(1, 32);
            this.grdStock.Name = "grdStock";
            this.grdStock.Size = new System.Drawing.Size(444, 87);
            this.grdStock.TabIndex = 45;
            this.grdStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStock_CellContentClick);
            // 
            // StockID
            // 
            this.StockID.HeaderText = "StockID";
            this.StockID.Name = "StockID";
            // 
            // StockName
            // 
            this.StockName.HeaderText = "Stock Name";
            this.StockName.Name = "StockName";
            // 
            // SaleP
            // 
            this.SaleP.HeaderText = "Sale Price";
            this.SaleP.Name = "SaleP";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // lblAmountOfItems
            // 
            this.lblAmountOfItems.AutoSize = true;
            this.lblAmountOfItems.Location = new System.Drawing.Point(10, 147);
            this.lblAmountOfItems.Name = "lblAmountOfItems";
            this.lblAmountOfItems.Size = new System.Drawing.Size(82, 13);
            this.lblAmountOfItems.TabIndex = 44;
            this.lblAmountOfItems.Text = "Amount of items";
            // 
            // txtQtySold
            // 
            this.txtQtySold.Location = new System.Drawing.Point(98, 140);
            this.txtQtySold.MaxLength = 3;
            this.txtQtySold.Name = "txtQtySold";
            this.txtQtySold.Size = new System.Drawing.Size(63, 20);
            this.txtQtySold.TabIndex = 43;
            // 
            // grpCart
            // 
            this.grpCart.Controls.Add(this.btnCheckout);
            this.grpCart.Controls.Add(this.label1);
            this.grpCart.Controls.Add(this.txtSaleValue);
            this.grpCart.Controls.Add(this.lstCart);
            this.grpCart.Location = new System.Drawing.Point(556, 81);
            this.grpCart.Name = "grpCart";
            this.grpCart.Size = new System.Drawing.Size(202, 307);
            this.grpCart.TabIndex = 44;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Items Selected";
            this.grpCart.Visible = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(25, 260);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(148, 24);
            this.btnCheckout.TabIndex = 47;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Total";
            // 
            // txtSaleValue
            // 
            this.txtSaleValue.Enabled = false;
            this.txtSaleValue.Location = new System.Drawing.Point(110, 206);
            this.txtSaleValue.MaxLength = 3;
            this.txtSaleValue.Name = "txtSaleValue";
            this.txtSaleValue.Size = new System.Drawing.Size(63, 20);
            this.txtSaleValue.TabIndex = 45;
            this.txtSaleValue.Text = "0.00";
            this.txtSaleValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(11, 27);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(178, 160);
            this.lstCart.TabIndex = 0;
            // 
            // grpPay
            // 
            this.grpPay.Controls.Add(this.rdoCash);
            this.grpPay.Controls.Add(this.rdoCredit);
            this.grpPay.Location = new System.Drawing.Point(19, 345);
            this.grpPay.Name = "grpPay";
            this.grpPay.Size = new System.Drawing.Size(405, 43);
            this.grpPay.TabIndex = 45;
            this.grpPay.TabStop = false;
            this.grpPay.Text = "Payment type";
            this.grpPay.Visible = false;
            this.grpPay.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(45, 19);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(73, 17);
            this.rdoCash.TabIndex = 1;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Cash Sale";
            this.rdoCash.UseVisualStyleBackColor = true;
            this.rdoCash.CheckedChanged += new System.EventHandler(this.rdoCash_CheckedChanged);
            // 
            // rdoCredit
            // 
            this.rdoCredit.AutoSize = true;
            this.rdoCredit.Location = new System.Drawing.Point(253, 19);
            this.rdoCredit.Name = "rdoCredit";
            this.rdoCredit.Size = new System.Drawing.Size(76, 17);
            this.rdoCredit.TabIndex = 0;
            this.rdoCredit.TabStop = true;
            this.rdoCredit.Text = "Credit Sale";
            this.rdoCredit.UseVisualStyleBackColor = true;
            this.rdoCredit.CheckedChanged += new System.EventHandler(this.rdoCredit_CheckedChanged);
            // 
            // grpCredit
            // 
            this.grpCredit.Controls.Add(this.btnAddCustomer);
            this.grpCredit.Controls.Add(this.btnCustomer);
            this.grpCredit.Controls.Add(this.lblCustomer);
            this.grpCredit.Controls.Add(this.txtCustomer);
            this.grpCredit.Controls.Add(this.grdCust);
            this.grpCredit.Location = new System.Drawing.Point(12, 407);
            this.grpCredit.Name = "grpCredit";
            this.grpCredit.Size = new System.Drawing.Size(433, 150);
            this.grpCredit.TabIndex = 46;
            this.grpCredit.TabStop = false;
            this.grpCredit.Text = "Customer";
            this.grpCredit.Visible = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(278, 24);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(58, 29);
            this.btnCustomer.TabIndex = 49;
            this.btnCustomer.Text = "Search";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(17, 32);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(88, 13);
            this.lblCustomer.TabIndex = 48;
            this.lblCustomer.Text = "Search Cusotmer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(111, 29);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(142, 20);
            this.txtCustomer.TabIndex = 47;
            // 
            // grdCust
            // 
            this.grdCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lblCustID,
            this.Surname,
            this.lblforename});
            this.grdCust.Location = new System.Drawing.Point(7, 57);
            this.grdCust.Name = "grdCust";
            this.grdCust.Size = new System.Drawing.Size(348, 87);
            this.grdCust.TabIndex = 46;
            this.grdCust.Visible = false;
            this.grdCust.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCust_CellContentClick);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(375, 84);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(58, 29);
            this.btnAddCustomer.TabIndex = 50;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Visible = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblCustID
            // 
            this.lblCustID.HeaderText = "Customer ID";
            this.lblCustID.Name = "lblCustID";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // lblforename
            // 
            this.lblforename.HeaderText = "Forename";
            this.lblforename.Name = "lblforename";
            // 
            // frmProcessSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 569);
            this.Controls.Add(this.grpCredit);
            this.Controls.Add(this.grpPay);
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.grpStock);
            this.Controls.Add(this.btnSrh);
            this.Controls.Add(this.lblSaleID);
            this.Controls.Add(this.txtSaleID);
            this.Controls.Add(this.btnRegesterSale);
            this.Controls.Add(this.lblSaleDate);
            this.Controls.Add(this.txtSrh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmProcessSale";
            this.Text = "Process_Sale";
            this.Load += new System.EventHandler(this.frmProcessSale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpStock.ResumeLayout(false);
            this.grpStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).EndInit();
            this.grpCart.ResumeLayout(false);
            this.grpCart.PerformLayout();
            this.grpPay.ResumeLayout(false);
            this.grpPay.PerformLayout();
            this.grpCredit.ResumeLayout(false);
            this.grpCredit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegesterSale;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.TextBox txtSrh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label lblSaleID;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.Button btnSrh;
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView grdStock;
        private System.Windows.Forms.Label lblAmountOfItems;
        private System.Windows.Forms.TextBox txtQtySold;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaleValue;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.GroupBox grpPay;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.RadioButton rdoCredit;
        private System.Windows.Forms.GroupBox grpCredit;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.DataGridView grdCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblforename;
    }
}