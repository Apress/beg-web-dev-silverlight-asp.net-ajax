<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Example2._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <script language="javascript">
        function Body_OnLoad()
        {
            Example2.AddService.AddEm(3,4,onReturn,onTimeOut);
        }
        function onReturn(result)
        {
            alert(result);
        }
        function onTimeOut(result)
        {
            alert("Time Out:" + result);
        }
    </script>
</head>
<body onload="Body_OnLoad()">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="AddService.asmx" />
            </Services>
        </asp:ScriptManager>
    <div>
    
    </div>
    </form>
</body>
</html>
