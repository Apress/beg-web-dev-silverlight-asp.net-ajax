<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorksConnectionString %>"
            SelectCommand="SELECT AddressLine1, PostalCode FROM Person.Address WHERE (PostalCode = @PostalCode)">
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="98011" Name="PostalCode" QueryStringField="ZIP" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
        <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataSourceID="SqlDataSource1"
            ForeColor="#333333">
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <ItemTemplate>
                Address:
                <asp:Label ID="AddressLine1Label" runat="server" Text='<%# Eval("AddressLine1") %>'></asp:Label>,<asp:Label
                    ID="PostalCodeLabel" runat="server" Text='<%# Eval("PostalCode") %>'></asp:Label><br />
            </ItemTemplate>
            <AlternatingItemStyle BackColor="White" />
            <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        </asp:DataList>
    </form>
</body>
</html>
