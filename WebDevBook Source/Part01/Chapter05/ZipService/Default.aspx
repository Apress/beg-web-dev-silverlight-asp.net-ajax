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
        Addresses for postal code:
        <asp:TextBox ID="TBZip" runat="server">98011</asp:TextBox>
        <asp:Button ID="BtnQuery" runat="server" Text="Query" /><br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAddress"
            TypeName="AddressData.Service" >
            <SelectParameters>
                <asp:FormParameter DefaultValue="98011" FormField="TBZip" Name="strZIP" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1">
        </asp:GridView>
    </form>
</body>
</html>
