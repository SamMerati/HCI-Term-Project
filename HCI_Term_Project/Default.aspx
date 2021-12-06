<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HCI_Term_Project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="./Content/Login.css">
</head>
<body>
    <form id="form1" runat="server">
        <div><div id="header">
  <div class="logo">
  </div>
</div>
<div id="main">
  <div id="form" style="text-align:center">
    &nbsp;<asp:Label ID="Label1" runat="server" Text="Login to your Spotify account" Font-Size="Large" ForeColor="White"></asp:Label>
      <br /><br />
      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" BackColor="#339933" BorderStyle="None" Font-Size="Large" />
  </div>
</div>
        </div>
    </form>
</body>
</html>