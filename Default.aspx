<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  
    <title>jQuery UI Autocomplete</title>   

    <script src="../Scripts/js/jquery-1.12.4.min.js" type = "text/javascript"></script>
    <script src="../Scripts/js/jquery-ui.min.js" type = "text/javascript"></script>
    <link href="../Scripts/css/jquery-ui.css" rel = "Stylesheet" type="text/css" />
    
    <script src="../Scripts/js/AutoComplete.js"></script>

</head>
<body>

    <form id="form1" runat="server">
        <asp:Label runat="server" >Name: </asp:Label>
        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
        <asp:HiddenField ID="hfId" runat="server" />
       
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </form> 
 
</body>
</html>
