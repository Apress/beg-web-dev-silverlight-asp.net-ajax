﻿<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <title>Sample 3</title>
        <object type="application/x-informationcard" name="_xmlToken">
            <param name="tokenType" value="urn:oasis:names:tc:SAML:1.0:assertion" />
            <param name="requiredClaims" value="http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress http://schemas.xmlsoap.org/ws/2005/05/identity/claims/privatepersonalidentifier" />
        </object>
    <script language="javascript">
            function GoGetIt()
            {
                var xmltkn=document.getElementById("_xmltoken");
                var thetextarea = document.getElementById("xmltoken");
                thetextarea.value = xmltkn.value ;
            }
        </script>
</head>
<body>
    <form id="form1" method="post" action="SignedIn.aspx">
    <div>
        <button name="go" id="go" onclick="javascript:GoGetIt();">Click here to get the token.</button>
        <button type="submit">Click here to send the card to the server</button>
        <textarea cols=100 rows=20 id="xmltoken" name="xmlToken" ></textarea>
    </div>
    </form>

</body>
</html>