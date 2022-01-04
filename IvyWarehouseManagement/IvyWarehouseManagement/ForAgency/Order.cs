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

namespace IvyWarehouseManagement
{
    public partial class Order : Form
    {
        SqlConnection conn;
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            conn = Connect.ConnectSQL();

            try
            {
                conn.Open();
                
                initPage();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void initPage()
        {
            loadProduct();
            for (int i = 0; i < orderTable.RowCount; i++)
            {
                orderTable.Rows[i].Cells[4].Value = "0";
            }
        }

        private void loadProduct()
        {
            string command = "Select productID [ID], productName [Name], unit [Unit], cast(exportPrice as bigint) [Price] From product";

            SqlDataAdapter adapter = new SqlDataAdapter(command, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataColumn dc = new DataColumn("Quantity");
            dt.Columns.Add(dc);

            orderTable.DataSource = dt;
            orderTable.Columns[1].Width = 190;

            orderTable.Columns[0].ReadOnly = true;
            orderTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderTable.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderTable.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            orderTable.Columns[1].ReadOnly = true;
            orderTable.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            orderTable.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderTable.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            orderTable.Columns[2].ReadOnly = true;
            orderTable.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderTable.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderTable.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            orderTable.Columns[3].ReadOnly = true;
            orderTable.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderTable.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderTable.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            orderTable.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            orderTable.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderTable.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            orderTable.ClearSelection();

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
            try
            {
                conn.Open();
                command = "Insert into ordering Values ('" + receivedNoteID.Text + "','A02',getdate(),'Pending')";
                cmd = new SqlCommand(command, conn);
                read = cmd.ExecuteReader();
                read.Close();


                for (int i = 0; i < orderTable.RowCount; i++)
                {
                    string test = orderTable.Rows[i].Cells[4].Value.ToString();
                    if (int.TryParse(test, out int val))
                    {
                        if (test.Length > 0)
                        {
                            int tmp = int.Parse(orderTable.Rows[i].Cells[4].Value.ToString());
                            if (tmp > 0)
                            {

                                command = "exec dbo.addinOrder '" + receivedNoteID.Text+ "','" + orderTable.Rows[i].Cells[0].Value.ToString() + "'," + (float)tmp;
                                cmd = new SqlCommand(command, conn);

                                read = cmd.ExecuteReader();
                                read.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter number only.");
                        break;
                    }
                }
                initPage();
                receivedNoteID.Text = "";
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
