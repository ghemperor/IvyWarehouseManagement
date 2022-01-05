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
    public partial class Dashboard : Form
    {
        SqlConnection conn;
        Int64 income = 0, spend = 0;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            conn = Connect.ConnectSQL();
            initPage();
        }

        private void initPage()
        {
            try
            {
                conn.Open();
                // import table
                string command = "select i.billID, p.productID, p.productName, i.quantity, i.importTime ";
                command += "from product p, import i ";
                command += "where p.productID = i.productID";

                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataReader read = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                DataColumn dc = new DataColumn("BillID");
                dt.Columns.Add(dc);
                dc = new DataColumn("ProductID");
                dt.Columns.Add(dc);
                dc = new DataColumn("ProductName");
                dt.Columns.Add(dc);
                dc = new DataColumn("Quantity");
                dt.Columns.Add(dc);
                dc = new DataColumn("ImportDate");
                dt.Columns.Add(dc);

              
                while (read.Read())
                {
                    DataRow row = dt.NewRow();
                    row["BillID"] = read.GetString(0);
                    row["ProductID"] = read.GetString(1);
                    row["ProductName"] = read.GetString(2);
                    row["Quantity"] = read.GetValue(3);
                    row["ImportDate"] = read.GetValue(4);
                    dt.Rows.Add(row);

                }
                read.Close();
                if (dt.Rows.Count > 0)
                {
                    importTable.DataSource = dt;

                }
                else { }


                command = "select i.billID, Cast( (p.importPrice*i.quantity) as bigint)";
                command += "from product p, import i ";
                command += "where p.productID = i.productID";
                cmd = new SqlCommand(command, conn);
                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    spend += Int64.Parse(read.GetSqlInt64(1).ToString());
                }
                read.Close();
                txtSpend.Text = spend + "";
                // export
                string commandd = "select ex.billID, p.productID, p.productName, oi.quantity, exportTime ";
                commandd += "From ordering, ordering_items oi, product p, export ex ";
                commandd += "where ordering.orderID = oi.listID and oi.productID = p.productID and ex.orderID = ordering.orderID ";

                SqlCommand cmdd = new SqlCommand(commandd, conn);
                SqlDataReader readd = cmdd.ExecuteReader();

                DataTable dtt = new DataTable();
                DataColumn dcc = new DataColumn("BillID");
                dtt.Columns.Add(dcc);
                dcc = new DataColumn("ProductID");
                dtt.Columns.Add(dcc);
                dcc = new DataColumn("ProductName");
                dtt.Columns.Add(dcc);
                dcc = new DataColumn("Quantity");
                dtt.Columns.Add(dcc);
                dcc = new DataColumn("ExportDate");
                dtt.Columns.Add(dcc);

                while (readd.Read())
                {
                    DataRow roww = dtt.NewRow();
                    roww["BillID"] = readd.GetString(0);
                    roww["ProductID"] = readd.GetString(1);
                    roww["ProductName"] = readd.GetString(2);
                    roww["Quantity"] = readd.GetValue(3);
                    roww["ExportDate"] = readd.GetValue(4);
                    dtt.Rows.Add(roww);
                }
                readd.Close();
                if (dtt.Rows.Count > 0)
                {
                    exportTable.DataSource = dtt;
                }
                else { }
                
                
                commandd = "select ex.billID,Cast((oi.quantity * p.exportPrice) as bigint) ";
                commandd += "From ordering o, ordering_items oi, product p, export ex ";
                commandd += "where o.orderID = oi.listID and oi.productID = p.productID and ex.orderID = o.orderID ";
                cmdd = new SqlCommand(commandd, conn);
                readd = cmdd.ExecuteReader();

                while (readd.Read())
                {
                    income += Int64.Parse(readd.GetSqlInt64(1).ToString());
                }
                read.Close();
                txtIncome.Text = income + "";

                if(income - spend > 0)
                {
                    txtTurnover.Text = "Profit: "+ (income-spend) + "";
                }
                else if(income - spend < 0)
                {
                    txtTurnover.Text = "Loss: " + (spend - income) + "";
                }
                else
                {
                    txtTurnover.Text = "Draw";
                }

                conn.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void exportTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
