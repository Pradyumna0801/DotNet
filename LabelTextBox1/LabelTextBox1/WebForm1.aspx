<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="LabelTextBox1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>   

        .container  {
            border:2px solid black;
           width:200px ;
           padding: 20px;
           background-color:aqua;
           border-radius :5px;
        }
    </style>
</head>
    
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Products</h2>

            <asp:Panel ID="Panel1" runat="server">

                <asp:Label ID="Label1" runat="server">Product Name: </asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

                <asp:Label ID="Label2" runat="server" Text="Label">Quantity: </asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />

                <asp:Label ID="Label3" runat="server" Text="Label">Rate: </asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />

                <asp:Button ID="Button1" runat="server" Text="Calculate" /><br />

                <asp:Label ID="Label4" runat="server" Text="Label">Amount:</asp:Label>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />

                <asp:Label ID="Label5" runat="server" Text="Label">Discount(10%): </asp:Label>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />

                <asp:Label ID="Label6" runat="server" Text="Label">Net Ammount: </asp:Label>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>

                <asp:Button ID="Button2" runat="server" Text="Clear" />



            </asp:Panel>


        </div>
    </form>
</body>
</html>
