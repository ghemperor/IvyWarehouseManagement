﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IvyWarehouseManagement.Forms
{
    public partial class Export : Form
    {
        SqlConnection conn;
        SqlConnection connect;
        public Export()
        {
            InitializeComponent();
        }


        private void Export_Load(object sender, EventArgs e)
        {
            conn = Connect.ConnectSQL();
            try
            {
                conn.Open();
                loadProduct();
                initPage();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
        }

        string[] orderID= { };

        private void initPage()
        {
            string command = "Select accID [ID], Name From Account Where Role = 'Customer' ";

            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                orderID.Append(reader.GetString(0));
                ordererList.Items.Add(reader.GetSqlString(1));
            }
            ordererList.SelectedIndex = 0;
            reader.Close();
            for (int i = 0; i < exportTable.RowCount; i++)
            {
                exportTable.Rows[i].Cells[5].Value = "0";
            }
        }
        private void loadProduct()
        {
            string commandd = "Select productID [ID], productName [Name], productQuantity [Inventory], unit [Unit], cast(exportPrice as bigint) [Price] From product";

            SqlDataAdapter adapter = new SqlDataAdapter(commandd, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataColumn dc = new DataColumn("Export value");
            dt.Columns.Add(dc);
         

            exportTable.DataSource = dt;

            exportTable.Columns[0].Width = 100;
            exportTable.Columns[3].Width = 100;
            exportTable.Columns[5].Width = 100;

            exportTable.Columns[0].ReadOnly = true;
            exportTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            exportTable.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            exportTable.Columns[1].ReadOnly = true;
            exportTable.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            exportTable.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            exportTable.Columns[2].ReadOnly = true;
            exportTable.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            exportTable.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            exportTable.Columns[3].ReadOnly = true;
            exportTable.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            exportTable.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            exportTable.Columns[4].ReadOnly = true;
            exportTable.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            exportTable.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            exportTable.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            exportTable.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            exportTable.ClearSelection();

        }
      

    
        private void ordererList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            AreYouSure.Visible = true;
        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            string command;
            SqlCommand cmd;
            SqlDataReader read;
            // Code run
            try
            {
                conn.Open();

                for (int i = 0; i < exportTable.RowCount; i++)
                {
                    string test = exportTable.Rows[i].Cells[5].Value.ToString();
                    if (int.TryParse(test, out int val))
                    {
                        if (test.Length > 0)
                        {
                            int tmp = int.Parse(exportTable.Rows[i].Cells[5].Value.ToString());
                            if (tmp > 0)
                            {

                                command = "exec dbo.addinImport '" + receivedNoteID.Text + "','" + exportTable.Rows[i].Cells[0].Value.ToString() + "'," + (float)tmp;
                                cmd = new SqlCommand(command, conn);

                                read = cmd.ExecuteReader();
                                read.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter number only.");
                        conn.Close();
                        return;
                    }
                }

                command = "exec dbo.exportExecute '" + receivedNoteID.Text + "'";
                cmd = new SqlCommand(command, conn);
                read = cmd.ExecuteReader();
                read.Close();
                exportTable.Columns.RemoveAt(5);
                loadProduct();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            AreYouSure.Visible = false;
        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            AreYouSure.Visible = false;
        }
    }
}