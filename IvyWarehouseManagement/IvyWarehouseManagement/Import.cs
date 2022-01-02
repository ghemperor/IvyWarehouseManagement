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


                conn.Close();
            }
            catch
            {
                MessageBox.Show("Check Connect.cs");
            }
        }

        private void loadProduct()
        {
            string command = "Select productID [ID], productName [Name], productQuantity [Inventory], unit [Unit], supplier [Supplier]  From product";

            SqlDataAdapter adapter = new SqlDataAdapter(command,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            importTable.DataSource = ds.Tables[0];
            importTable.Columns.Add("Column", "Add");


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

            importTable.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            importTable.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            // Code run 
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
    }
}
