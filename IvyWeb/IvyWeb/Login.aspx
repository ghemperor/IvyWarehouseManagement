<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IvyWeb.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        #form{
            width:400px;
            min-width:400px;
            max-width:400px;

            background-color:lightblue;
            margin:auto;
        }
        #username,#password,#button{
            height:40px;
            position:relative;
        }

        .row{
            font-size:16px;
            width:100px;
            min-width:100px;
            max-width:100px;
            font-weight:bold;

            position:absolute;
            top:5px;
            left:20px;
        }
        .txtBox{
            font-size:16px;
            width:290px;
            min-width:290px;
            max-width:290px;

            position:absolute;
            top:5px;
            right:10px;
        }
        .loginBtn{
            font-size:18px;

            width:100px;
            min-width:100px;
            max-width:100px;

            position:absolute;
            top:5px;
            right:10px;
        }
    </style>
    <h2><%: Title %></h2>
    <div id="form">
        <div id="username">
            <asp:Label ID="Label1" runat="server" Text="Username:" CssClass="row"></asp:Label> 
       
            <asp:TextBox ID="txtusername" runat="server" CssClass="txtBox"></asp:TextBox>
        </div>
        <div id="password">
            <asp:Label ID="Label2" runat="server" Text="Password:" CssClass="row"></asp:Label> 
            
            <asp:TextBox ID="txtpassword" runat="server" CssClass="txtBox" TextMode="Password"></asp:TextBox>
        </div>
        <div id="button">
            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="loginBtn" OnClick="btnLogin_Click"/>
        </div>
    </div>
    
</asp:Content>
