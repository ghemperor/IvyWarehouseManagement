using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Report;

namespace IvyWarehouseManagement.Forms
{
    public partial class Export : Form
    {
        SqlConnection conn;
        public Export()
        {
            InitializeComponent();
        }


        private void Export_Load(object sender, EventArgs e)
        {
            conn = Connect.ConnectSQL();
            initPage();
        }

        string[] orderID= { };

        private void initPage()
        {
            try
            {
                conn.Open();
                loadOrder();
                AreYouSure.Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void loadOrder()
        {
            string commandd = "Select o.orderID [Order ID], o.ordererID [Agency ID], o.orderDate [Order date] From ordering o where deliveryStatus = 'Pending'";

            SqlDataAdapter adapter = new SqlDataAdapter(commandd, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            /*
            DataColumn dc = new DataColumn("Export value");
            dt.Columns.Add(dc);
            */
            if (dt.Rows.Count > 0)
            {
                orderTable.DataSource = dt;

                orderTable.Columns[0].ReadOnly = true;
                orderTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                orderTable.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

                orderTable.Columns[1].ReadOnly = true;
                orderTable.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                orderTable.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                orderTable.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                orderTable.Columns[2].ReadOnly = true;
                orderTable.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                orderTable.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

                orderTable.ClearSelection();
            }
            else
            {
                dt = new DataTable();
                orderTable.DataSource = dt;
            }

        }

        private void loadOrderInfo() {
            string orderid = orderTable.SelectedRows[0].Cells[0].Value.ToString();
            string command = "Select oi.productID [Product ID], p.productName [Product name], exportPrice [Price], quantity [Quantity] From ordering o, product p, ordering_items oi where o.orderID = '"+ orderid + "' and o.orderID = oi.listID and oi.productID = p.productID";
            SqlDataAdapter adapter = new SqlDataAdapter(command, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            exportTable.DataSource = dt;

        }
        private void orderTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = orderTable.SelectedRows[0].Index;
            orderTable.Rows[rowindex].Selected = true;
        }

        private void ordererList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            loadOrderInfo();
            AreYouSure.Visible = true;
        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            string command;
            SqlCommand cmd;
            SqlDataReader read;
            // Code run
            Boolean printSuccess = printBill();

            if (printSuccess)
            {
                try
                {
                    conn.Open();
                    string orderid = orderTable.SelectedRows[0].Cells[0].Value.ToString();

                    command = "exec dbo.exportExecute '" + orderid + "'";
                    cmd = new SqlCommand(command, conn);
                    read = cmd.ExecuteReader();
                    read.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
            initPage();
        }
        private Boolean printBill()
        {
            var folder = Directory.GetParent(Directory.GetParent(Directory.GetParent(
                        Directory.GetCurrentDirectory()).ToString()).ToString()).ToString();
            string formlocation = folder+ @"\ExportProcess\Form\Export.xlsx";
            string savelocation = folder + @"\ExportProcess\Result\";

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true, InitialDirectory = savelocation })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var template = new XLTemplate(formlocation);
                        ClosedXML.Excel.IXLWorkbook book = template.Workbook;
                        ClosedXML.Excel.IXLWorksheet sheet = book.Worksheet("Export");

                        int rowstart = 3; // 2-Collumn's Header
                        for (int i = 0; i < exportTable.Rows.Count; i++)
                        {
                            sheet.Cells("B" + (rowstart + i)).Value = exportTable.Rows[i].Cells[0].Value.ToString();
                            sheet.Cells("C" + (rowstart + i)).Value = exportTable.Rows[i].Cells[1].Value.ToString();
                            sheet.Cells("D" + (rowstart + i)).Value = exportTable.Rows[i].Cells[2].Value.ToString();
                            sheet.Cells("E" + (rowstart + i)).Value = exportTable.Rows[i].Cells[3].Value.ToString();
                        }
                        template.Generate();
                        template.SaveAs(sfd.FileName);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return false;
                    }
                }

                return false;
            }
        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            AreYouSure.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
