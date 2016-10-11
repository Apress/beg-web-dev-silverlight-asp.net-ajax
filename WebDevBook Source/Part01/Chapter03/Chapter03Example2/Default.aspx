<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        First Number &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox><br />
        Second Number&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtSecond" runat="server"></asp:TextBox><br />
        <br />
        <input name="optOperation" value="Add" type="radio" checked="CHECKED" style="width: 20px" />Add<br />
        <input name="optOperation" value="Subtract" type="radio" />Subtract<br />
        <br />
        <input name="btnSubmit" type="submit" value="submit" />
        <br />
        <br />
        The Result is:
        <asp:Literal ID="litResult" runat="server"></asp:Literal></div>
    </form>
</body>
</html>
