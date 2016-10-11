<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CountryCode.aspx.cs" Inherits="CountryCode" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<script language="javascript" type="text/javascript">
// <!CDATA[

function btnLookup_onclick() {
    var strCC = document.all("txtCC").value;;
    DataService.GetCountryForRegion(strCC, onReturn, onTimeOut);
}

function onReturn(result)
{
    CC.innerHTML = result;
}

function onTimeOut(result)
{
    alert("You hit a timeout!");
}

// ]]>
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="DataService.asmx" />
            </Services>
        </asp:ScriptManager>
        <br />
        Enter Country Code
        <input id="txtCC" type="text" /><br />
        <br />
        <input id="btnLookup" type="button" value="Look Up" onclick="return btnLookup_onclick()" /><br />
        <br />
        <div id="CC"></div>
    
    </div>
    </form>
</body>
</html>
