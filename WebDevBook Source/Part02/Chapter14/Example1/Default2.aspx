<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<script language="javascript" type="text/javascript">
// <!CDATA[

function Button1_onclick() {
    var MyBoat = new Vehicles.Boat('Pedal','5','Stella');
    alert(MyBoat.getBoatDetails());
}

// ]]>
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Path="Boat.js" />
            </Scripts>
        </asp:ScriptManager>
    
    </div>
        <input id="Button1" type="button" value="button" onclick="return Button1_onclick()" />
    </form>
</body>
</html>
