﻿namespace Hardware_Syst
{
    partial class frmAnalysisStock
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
            this.btnStockAnalsis = new System.Windows.Forms.Button();
            this.lblStockType = new System.Windows.Forms.Label();
            this.cboStockType = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdStockAnalysis = new System.Windows.Forms.DataGridView();
            this.Stock_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty_sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStockAnalsis
            // 
            this.btnStockAnalsis.Location = new System.Drawing.Point(323, 158);
            this.btnStockAnalsis.Name = "btnStockAnalsis";
            this.btnStockAnalsis.Size = new System.Drawing.Size(123, 23);
            this.btnStockAnalsis.TabIndex = 18;
            this.btnStockAnalsis.Text = "Stock Analysis";
            this.btnStockAnalsis.UseVisualStyleBackColor = true;
            this.btnStockAnalsis.Visible = false;
            this.btnStockAnalsis.Click += new System.EventHandler(this.btnStockAnalsis_Click);
            // 
            // lblStockType
            // 
            this.lblStockType.AutoSize = true;
            this.lblStockType.Location = new System.Drawing.Point(243, 83);
            this.lblStockType.Name = "lblStockType";
            this.lblStockType.Size = new System.Drawing.Size(62, 13);
            this.lblStockType.TabIndex = 17;
            this.lblStockType.Text = "Department";
            // 
            // cboStockType
            // 
            this.cboStockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStockType.FormattingEnabled = true;
            this.cboStockType.Items.AddRange(new object[] {
            "EL - Electrical",
            "PL - Plumbing",
            "HW - Hardware ",
            "HO - Household",
            "TL - Tools"});
            this.cboStockType.Location = new System.Drawing.Point(325, 80);
            this.cboStockType.Name = "cboStockType";
            this.cboStockType.Size = new System.Drawing.Size(121, 21);
            this.cboStockType.TabIndex = 16;
            this.cboStockType.SelectedIndexChanged += new System.EventHandler(this.cboStockType_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // grdStockAnalysis
            // 
            this.grdStockAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStockAnalysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stock_ID,
            this.Stock_Name,
            this.Qty,
            this.Cost_Price,
            this.Sale_Price,
            this.Qty_sold,
            this.Total_Profit});
            this.grdStockAnalysis.Location = new System.Drawing.Point(12, 187);
            this.grdStockAnalysis.Name = "grdStockAnalysis";
            this.grdStockAnalysis.Size = new System.Drawing.Size(743, 240);
            this.grdStockAnalysis.TabIndex = 47;
            this.grdStockAnalysis.Visible = false;
            // 
            // Stock_ID
            // 
            this.Stock_ID.HeaderText = "Stock ID";
            this.Stock_ID.Name = "Stock_ID";
            // 
            // Stock_Name
            // 
            this.Stock_Name.HeaderText = "Name";
            this.Stock_Name.Name = "Stock_Name";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Cost_Price
            // 
            this.Cost_Price.HeaderText = "Cost Price";
            this.Cost_Price.Name = "Cost_Price";
            // 
            // Sale_Price
            // 
            this.Sale_Price.HeaderText = "Sale Price";
            this.Sale_Price.Name = "Sale_Price";
            // 
            // Qty_sold
            // 
            this.Qty_sold.HeaderText = "Quantity Sold";
            this.Qty_sold.Name = "Qty_sold";
            // 
            // Total_Profit
            // 
            this.Total_Profit.HeaderText = "Total Profit";
            this.Total_Profit.Name = "Total_Profit";
            // 
            // frmAnalysisStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 496);
            this.Controls.Add(this.grdStockAnalysis);
            this.Controls.Add(this.btnStockAnalsis);
            this.Controls.Add(this.lblStockType);
            this.Controls.Add(this.cboStockType);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnalysisStock";
            this.Text = "frmAnalysisStock";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStockAnalsis;
        private System.Windows.Forms.Label lblStockType;
        private System.Windows.Forms.ComboBox cboStockType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdStockAnalysis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty_sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Profit;
    }
}