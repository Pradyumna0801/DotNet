<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="WebApplication5.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>This is Home Page</h1>
            <asp:HyperLink ID="link1" runat="server" NavigateUrl="Private/Restricted.aspx">
                GO TO DATA PAGE
            </asp:HyperLink>
        </div>
    </form>
</body>
</html>
