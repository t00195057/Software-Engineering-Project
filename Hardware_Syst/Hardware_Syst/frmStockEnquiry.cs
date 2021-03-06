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
using System.Windows.Forms.DataVisualization.Charting;

namespace Hardware_Syst
{
    public partial class frmStockEnquiry : Form
    {
        frmMainMenu parent;
        public frmStockEnquiry(frmMainMenu Parent)
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
                chtData.Visible = false;
                grdEnquiry.Visible = false;
                return;
            }

           else if (!alphanumericCheck.IsMatch(txtStockName.Text))
            {
                MessageBox.Show("Stock Name must use alphanumeric characters");
                chtData.Visible = false;
                grdEnquiry.Visible = false;
                txtStockName.Clear();
                txtStockName.Focus();
                return;
            }

            else
            {
                DataSet ds = new DataSet();
                
                grdStockSearch.DataSource = Stock.getMatchingStock(ds, txtStockName.Text).Tables["ss"];
                grdStockSearch.AllowUserToAddRows = false;


                if (grdStockSearch.RowCount == 0)
                {
                    grpSearch.Visible = false;
                    MessageBox.Show(Convert.ToString(txtStockName.Text) + " does not exist in the system please try another item of stock");
                    txtStockName.Text = "";
                    chtData.Visible = false;
                    grdEnquiry.Visible = false;
                }
                else
                {
                    grpSearch.Visible = true;
                }
            }
           
        }      

        private void grdStockSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grdEnquiry.Refresh();
            chtData.Series.Clear();
            grdEnquiry.Visible = true;
            DataSet ds = new DataSet();
            grdEnquiry.DataSource = Stock.getEnquiry(ds, Convert.ToInt16(grdStockSearch.Rows[grdStockSearch.CurrentCell.RowIndex].Cells[0].Value)).Tables["ss"];

   
                //define chart
                defineChart();

                //Define the chart series
                defineSeries();


                //fill Chart
                fillChart(ds);

            chtData.Visible = true;

        }
        private void defineChart()
        {
            //define chart
            chtData.Size = new Size(750, 300);
            chtData.ChartAreas[0].Name = "mainArea";
            chtData.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chtData.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

            chtData.ChartAreas["mainArea"].AxisY.Minimum = 0;
            chtData.ChartAreas["mainArea"].AxisY.Interval = 20;
            chtData.ChartAreas["mainArea"].AxisY.Title = "sales";

            chtData.ChartAreas["mainArea"].AxisX.Interval = 1;
            chtData.ChartAreas["mainArea"].AxisX.Title = "Month";

            chtData.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;

            chtData.Titles.Clear(); 
            chtData.Titles.Add("Monthly Revenue 2017");
        }

        private void defineSeries()
        {
            chtData.Series.Clear();
            chtData.Series.Add("Revenue");

            chtData.Series["Revenue"].ChartType = SeriesChartType.Column;
            chtData.Series["Revenue"].XValueType = ChartValueType.String;
        }

        private void fillChart(DataSet ds)
        {
           
            chtData.Series["Revenue"].Points.Clear();

            for (int i = 1; i <= 12; i++)
            { 
                    chtData.Series["Revenue"].Points.AddXY(monthName(i), Sale.getStockSales(ds,Convert.ToString(monthName(i)+"-18"), Convert.ToInt16(grdStockSearch.Rows[grdStockSearch.CurrentCell.RowIndex].Cells[0].Value)));
            }
        }
        private string monthName(int MonthNo)
        {
            String strMonth = "";

            switch (MonthNo)
            {
                case 1:
                    strMonth = "JAN";
                    break;
                case 2:
                    strMonth = "FEB";
                    break;
                case 3:
                    strMonth = "MAR";
                    break;
                case 4:
                    strMonth = "APR";
                    break;
                case 5:
                    strMonth = "MAY";
                    break;
                case 6:
                    strMonth = "JUN";
                    break;
                case 7:
                    strMonth = "JUL";
                    break;
                case 8:
                    strMonth = "AUG";
                    break;
                case 9:
                    strMonth = "SEP";
                    break;
                case 10:
                    strMonth = "OCT";
                    break;
                case 11:
                    strMonth = "NOV";
                    break;
                case 12:
                    strMonth = "DEC";
                    break;
            }

            return strMonth;
        }   
    }
}
