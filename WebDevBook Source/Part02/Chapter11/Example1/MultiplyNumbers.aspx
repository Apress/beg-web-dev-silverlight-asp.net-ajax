<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MultiplyNumbers.aspx.cs" Inherits="MultiplyNumbers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label2" runat="server" Text="First"></asp:Label>
        &nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server">0</asp:TextBox><br />
        <asp:Label ID="Label1" runat="server" Text="Second"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server">0</asp:TextBox>&nbsp;<br />
        &nbsp;
        <asp:Button ID="btnMult" runat="server" OnClick="btnMult_Click" Text="Multiply" Width="193px" /><br />
        <asp:Label ID="lblAnswer" runat="server" Height="45px" Text="Answer" Width="201px"></asp:Label></div>
    </form>
</body>
</html>
