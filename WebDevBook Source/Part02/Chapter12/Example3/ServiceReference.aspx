<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ServiceReference.aspx.cs" Inherits="ServiceReference" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<script language="javascript" type="text/javascript">
// <!CDATA[

function Button1_onclick() {
    SimpleService.AddEm(3,4,onResult,onTimeOut);
}
function onResult(result)
{
    alert(result);
}
function onTimeOut(result)
{
    alert(timeout);
}

// ]]>
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="SimpleService.ASMX" InlineScript="True"/>
            </Services>
        </asp:ScriptManager>
        <input id="Button1" type="button" value="button" onclick="return Button1_onclick()" /></div>
    </form>
</body>
</html>
