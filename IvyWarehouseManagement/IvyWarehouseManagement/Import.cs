using System;
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
    public partial class Import : Form
    {
        SqlConnection conn;

        public Import()
        {
            InitializeComponent();
        }

        private void Import_Load(object sender, EventArgs e)
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

        private void initPage()
        {
            for (int i = 0; i < importTable.RowCount; i++)
            {
                importTable.Rows[i].Cells[5].Value = "0";
            }
        }

        private void loadProduct()
        {
            string command = "Select productID [ID], productName [Name], productQuantity [Inventory], unit [Unit], supplier [Supplier] From product";

            SqlDataAdapter adapter = new SqlDataAdapter(command,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataColumn dc = new DataColumn("Import value");
            dt.Columns.Add(dc);

            importTable.DataSource = dt;
            
            importTable.Columns[0].ReadOnly = true;
            importTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            importTable.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            importTable.Columns[1].ReadOnly = true;
            importTable.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            importTable.Columns[2].ReadOnly = true;
            importTable.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            importTable.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            importTable.Columns[3].ReadOnly = true;
            importTable.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            importTable.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            importTable.Columns[4].ReadOnly = true;
            importTable.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            importTable.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            importTable.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            importTable.ClearSelection();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            string command;
            SqlCommand cmd;
            SqlDataReader read;
            try
            {
                conn.Open();
            
                for (int i = 0; i < importTable.RowCount; i++)
                {
                    string test = importTable.Rows[i].Cells[5].Value.ToString();
                    if(int.TryParse(test, out int val))
                    {
                        if (test.Length > 0)
                        {
                            int tmp = int.Parse(importTable.Rows[i].Cells[5].Value.ToString());
                            if (tmp > 0)
                            {

                                command = "exec dbo.addinImport '" + receivedNoteID.Text + "','" + importTable.Rows[i].Cells[0].Value.ToString() + "'," + (float)tmp;
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
                
                  
           

                command = "exec dbo.importExecute '" + receivedNoteID.Text + "'";
                cmd = new SqlCommand(command, conn);
                read = cmd.ExecuteReader();
                read.Close();
                importTable.Columns.RemoveAt(5);
                loadProduct();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            AreYouSure.Visible = false;
        }

        private char toChar(object value)
        {
            throw new NotImplementedException();
        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            AreYouSure.Visible = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            AreYouSure.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
