﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Syst
{
    public partial class frmStockDiscontinue : Form
    {
        frmMainMenu parent;
        public frmStockDiscontinue(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Regex alphanumericCheck = new Regex("^[a-zA-Z][a-zA-Z0-9 ]*$");


            if (txtStockName.Text.Equals(""))
            {
                MessageBox.Show("Stock Name was left blank");
                txtStockName.Focus();
                return;
            }

           else if (!alphanumericCheck.IsMatch(txtStockName.Text))
            {
                MessageBox.Show("Stock Name must use alphanumeric characters");
                txtStockName.Clear();
                txtStockName.Focus();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                
                grdStockSearch.DataSource = Stock.getAvalableStock(ds, txtStockName.Text).Tables["ss"];
                grdStockSearch.AllowUserToAddRows = false;


                if (grdStockSearch.RowCount == 0)
                {
                    grpSearch.Visible = false;
                    MessageBox.Show(Convert.ToString(txtStockName.Text) + " does not exist in the system or may already by discontinued please try another item of stock");
                    txtStockName.Text = "";
                }
                else
                {
                    grpSearch.Visible = true;
                }
            }
        }       
        private void grdStockSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //get stock ID from col 0 of grid            
            Stock.discontinueStock(Convert.ToInt32(grdStockSearch.Rows[grdStockSearch.CurrentCell.RowIndex].Cells[0].Value));
            MessageBox.Show("This Stock has been discontinued");
            this.Close();
            parent.Show();
        }
           
    }
}
