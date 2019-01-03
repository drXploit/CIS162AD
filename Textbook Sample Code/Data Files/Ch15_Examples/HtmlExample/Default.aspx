<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #CCFF33; font-size: medium; color: #003300;">
<head runat="server">
    <title>HTML Controls Example</title>
	<style type="text/css">
		#Text1 {
			width: 265px;
			left: -9px;
			top: 0px;
			position: relative;
			height: 37px;
			margin-left: 15px;
			margin-top: 4px;
		}
		#Text2 {
			width: 265px;
			height: 37px;
			margin-left: 15px;
			margin-top: 4px;
			position: relative;
		}
		#Text3 {
			width: 265px;
			height: 37px;
			margin-left: 15px;
			margin-top: 4px;
			position: relative;
		}
		#txtEmail {
			width: 195px;
		}
		#txtFirst {
			width: 199px;
		}
		#txtLast {
			width: 190px;
		}
		</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    	<h1 style="text-align: center">
			Computer Club Registration Form</h1>
    
    </div>
	
	<h3>First name:&nbsp;
		<input id="txtFirst" runat="server" type="text" /></h3>
	<h3>Last&nbsp; name:&nbsp;
		<input id="txtLast" runat="server" type="text" /></h3>
	<h3>Email:&nbsp;
		<input id="txtEmail" runat="server" type="text" /></h3>
	<p style="text-align: center">
		<asp:Button ID="btnSubmit" runat="server" Text="Submit" 
	     Height="45px" Width="97px" OnClick="Button1_Click" />
    	
	<p style="text-align: center">
		<img alt="" src="Images/HAPPY.jpg" style="height: 34px; 
		 width: 48px; position: relative; top: -2px; left: 0px" /></p>
	
	<p style="text-align: center">
			&nbsp;</p>
		<asp:Label ID="lblOutput" runat="server" style="text-align: left" 
			Font-Size="X-Large"></asp:Label>
    </form>
	
	</body>
</html>
