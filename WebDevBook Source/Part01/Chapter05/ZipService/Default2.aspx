﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    	<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
		<asp:Button ID="Button1" runat="server" Text="Button" />
		<br />
		<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetAddress" 
		TypeName="AddressData.Service">
			<selectparameters>
				<asp:formparameter FormField="TextBox1" Name="strZIP" Type="String" 
				DefaultValue="98011" />
			</selectparameters>
		</asp:ObjectDataSource>
    
    </div>
    	<asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1">
		</asp:GridView>
    </form>
</body>
</html>