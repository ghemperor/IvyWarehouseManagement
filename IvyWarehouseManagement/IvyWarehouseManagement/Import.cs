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
            DataColumn dc = new DataColumn("Add...");
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
            // Code run
            for (int i = 0; i < importTable.RowCount; i++)
            {
                
                if (importTable.Rows[i].Cells[5].Value.ToString().Length > 0)
                {
                    MessageBox.Show(importTable.Rows[i].Cells[5].Value.ToString());
                    /*
                    int tmp = int.Parse(importTable.Rows[i].Cells[5].Value.ToString());
                    if (tmp > 0)
                    {
                        command = "exec dbo.addinImport '" + "fgthjh" + "','" + importTable.Rows[i].Cells[0].Value.ToString() + "'," + tmp;
                        cmd = new SqlCommand(command, conn);

                        read = cmd.ExecuteReader();
                        read.Close();
                    }
                    */
                }
                
            }

            /*
            command = "exec dbo.importExecute '" + "fgthjh" + "'";
            cmd = new SqlCommand(command, conn);
            read = cmd.ExecuteReader();
            read.Close();
            */



            AreYouSure.Visible = false;
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
