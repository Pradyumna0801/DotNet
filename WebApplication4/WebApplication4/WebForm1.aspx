<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />

            <asp:TreeView ID="TreeView1" DataSourceID="SiteMapDataSource1" runat="server">
                
            </asp:TreeView>
            <br />
            <h2>Menu Control</h2>
            <asp:Menu ID="Menu1" runat="server">
    <Items>
        <asp:MenuItem Text="Products">
            <asp:MenuItem Text="Mobile" NavigateUrl="Products/Mobile.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Laptop" NavigateUrl="Products/Laptop.aspx"></asp:MenuItem>
       
            </asp:MenuItem>
    
        <asp:MenuItem Text="Services">
            <asp:MenuItem Text="Finance" NavigateUrl="Services/Finance.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Healthcare" NavigateUrl="Services/Healthcare.aspx"></asp:MenuItem>
        </asp:MenuItem>
    </Items>
</asp:Menu>

            

        </div>
    </form>
</body>
</html>
