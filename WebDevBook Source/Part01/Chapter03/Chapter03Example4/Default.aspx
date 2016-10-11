<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server" id="theHead">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Welcome to my Page!"></asp:Label>
        <asp:Panel ID="Panel1" runat="server" Height="168px" Width="286px">
            This is a Panel Containing some Controls<br />
            <br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>Item 1</asp:ListItem>
                <asp:ListItem>Item 2</asp:ListItem>
                <asp:ListItem>Item 3</asp:ListItem>
            </asp:CheckBoxList>&nbsp;</asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="50px" Width="435px">
            This is another Panel containing some controls<br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
            <asp:Button ID="Button2" runat="server" Text="Button" /><br />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
