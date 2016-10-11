<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
<script language="javascript" type="text/javascript">
// <!CDATA[

function Button1_onclick() {
    var MyBoat = new Vehicles.Boat('Pedal','5','Stella');
    //alert(MyBoat.getBoatDetails());
    //alert(MyBoat.inheritsFrom(Vehicles.Boat));
    //alert(Vehicles.SpeedBoat.isInstanceOfType(MyBoat));
    var MySpeedBoat = new Vehicles.SpeedBoat('Intimidator', '10', 'Arnie', '_100cc');
    //alert(MySpeedBoat.getBoatDetails());
    //alert(MySpeedBoat.checkFuel());
    //alert(Vehicles.SpeedBoat.inheritsFrom(Vehicles.Boat));
    //alert(Vehicles.SpeedBoat.isInstanceOfType(MySpeedBoat));
    //alert(Vehicles.Boat.isInstanceOfType(MySpeedBoat));
    //alert(Vehicles.Boat.implementsInterface(Vehicles.IPowered));
    //alert(Vehicles.SpeedBoat.implementsInterface(Vehicles.IPowered));
    //alert(MySpeedBoat.getEngineType());
    //alert(eval("Vehicles.TaxClass." + MySpeedBoat.getEngineType() + ";"));
    //alert(eval(Vehicles.TaxClass.cc100cc));
    
    var a = ['Item 1','Item 2'];
    alert(a.toString());
    Array.add(a,'Item 3');
    alert(a.toString());
    
    
}



// ]]>
</script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <div style="width: 100px; height: 100px">
            <input id="Button1" type="button" value="button" onclick="return Button1_onclick()" /></div>
        <br />
        <script type="text/javascript" src="Boat.js" />

        &nbsp;
    </form>
    
</body>

</html>
