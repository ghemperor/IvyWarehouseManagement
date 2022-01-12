using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IvyWeb
{
    public partial class Order : Page
    {
        SqlConnection conn;


        protected void Page_Load(object sender, EventArgs e)
        {
            conn = Connect.ConnectSQL();

            if (Session["Username"] == null)
            {
                Response.Redirect("Login");
            }

            if (!Page.IsPostBack)
            {
                initPage();
            }

            
        }
        protected void initPage()
        {
            loadProduct();
        }

        protected void loadProduct()
        {
            try
            {
                conn.Open();
                string command = "Select productID [ID], productName [Name], unit [Unit], cast(exportPrice as bigint) [Price] From product";

                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataReader read = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                DataColumn dc; DataRow dr;
                dc = new DataColumn("Product ID"); dt.Columns.Add(dc);
                dc = new DataColumn("Product Name"); dt.Columns.Add(dc);
                dc = new DataColumn("Unit Type"); dt.Columns.Add(dc);
                dc = new DataColumn("Price"); dt.Columns.Add(dc);
                dc = new DataColumn("Quantity"); dt.Columns.Add(dc);

                while (read.Read())
                {
                    dr = dt.NewRow();
                    dr["Product ID"] = read.GetString(0);
                    dr["Product Name"] = read.GetString(1);
                    dr["Unit Type"] = read.GetString(2);
                    dr["Price"] = read.GetSqlInt64(3).ToString();
                    dr["Quantity"] = 0;
                    dt.Rows.Add(dr);
                }
                read.Close();

                importTable.DataSource = dt;
                importTable.DataBind();
                conn.Close();
            }
            catch
            {
                check.Text = "Load failed!";
            }
            
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            int total = 0;
            for(int i = 0; i < importTable.Rows.Count; i++)
            {
                int price = int.Parse(importTable.Rows[i].Cells[3].Text);
                int quantity = int.Parse(((TextBox) importTable.Rows[i].Cells[4].FindControl("quantity")).Text);
                total += price * quantity;
            }

            if (total > 0)
            {
                if (txtOrderID.Text.Trim().Length == 0)
                {
                    check.Text = "Please enter bill ID to order.";
                }
                else
                {
                    string billID = txtOrderID.Text;
                    Boolean checkP =  placeOrder(billID);
                    if (checkP)
                    {
                        check.Text = "Order successfully! Bill ID: " + billID;
                        txtOrderID.Text = "";
                        loadProduct();
                    }
                    else
                    {
                        check.Text = "This bill ID existed.";
                    }

                }
            }
            else
            {
                check.Text = "Nothing to place order!";
            }
        }

        protected Boolean placeOrder(string billID)
        {
            string command;
            SqlCommand cmd;
            SqlDataReader read;
            try
            {
                conn.Open();
                command = "Insert into ordering Values ('" + billID + "','A02', getdate(),'Pending')";
                cmd = new SqlCommand(command, conn);
                read = cmd.ExecuteReader();
                read.Close();

                for (int i = 0; i < importTable.Rows.Count; i++)
                {
                    int quantity = int.Parse(((TextBox)importTable.Rows[i].Cells[4].FindControl("quantity")).Text);
                    if (quantity > 0)
                    {
                        command = "exec dbo.addinOrder '" + billID + "','" + importTable.Rows[i].Cells[0].Text + "'," + quantity;
                        cmd = new SqlCommand(command, conn);
                        read = cmd.ExecuteReader();
                        read.Close();
                    }
                }

                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    }
