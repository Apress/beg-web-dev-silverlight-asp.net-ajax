<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddWIthUpdatePanel.aspx.cs" Inherits="Example2.AddWIthUpdatePanel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" Height="88px" Width="388px">
        <asp:TextBox ID="txtA" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtB" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Em Up" /><br />
        <asp:Label ID="lblAns" runat="server"></asp:Label></asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
