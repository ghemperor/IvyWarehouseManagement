<%@ Page Title="Order" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="IvyWeb.Order" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        #form{
            width:800px;
            min-width:800px;
            max-width:800px;

            background-color:whitesmoke;

            height:500px;
            min-height:500px;
            max-height:500px;

            position:relative;
            margin:auto;
        }
        #table{
            max-height:400px;
            overflow-y:scroll;
        }
        .gridView{
            width:100%;
        }
        .itemGrid {
            height:40px;
            padding:5px;
        }
        .headerGrid {
            height:50px;
            padding:5px;
            font-size:16px;
        }
        .txtOrderID{
            font-size:16px;
            width:150px;
            height:30px;

            position:absolute;
            bottom:60px;
            right:0;
        }

        .orderBtn{
            font-size:16px;
            width:100px;
            height:50px;

            position:absolute;
            bottom:0;
            right:0;
        }
    </style>
    <h2><%: Title %></h2>

    <div id="form">
        <div id="table">
            <asp:GridView ID="importTable" runat="server" AutoGenerateColumns="false" CssClass="gridView">
            <Columns>
                <asp:BoundField HeaderText="Product ID" DataField="Product ID" HeaderStyle-CssClass="headerGrid" ItemStyle-CssClass="itemGrid" />
                <asp:BoundField HeaderText="Product Name" DataField="Product Name" HeaderStyle-CssClass="headerGrid" ItemStyle-CssClass="itemGrid" />
                <asp:BoundField HeaderText="Unit Type" DataField="Unit Type" HeaderStyle-CssClass="headerGrid" ItemStyle-CssClass="itemGrid" />
                <asp:BoundField HeaderText="Price" DataField="Price" HeaderStyle-CssClass="headerGrid" ItemStyle-CssClass="itemGrid" />
                <asp:TemplateField HeaderText="Quantity" HeaderStyle-CssClass="headerGrid" ItemStyle-CssClass="itemGrid" HeaderStyle-Width="100">
                    <ItemTemplate>
                        <asp:TextBox ID="quantity" runat="server" TextMode="Number" min="0" max="100" step="1" Text="0">

                        </asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </div>
        
        <asp:Button Text="Place Order" runat="server" ID="btnOrder" OnClick="btnOrder_Click" CssClass="orderBtn"/>
        <asp:TextBox runat="server" ID="txtOrderID" CssClass="txtOrderID"></asp:TextBox>
    </div>
    <asp:Label ID="check" runat="server"></asp:Label>

</asp:Content>

