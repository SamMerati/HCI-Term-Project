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
  <div id="form">
    <input name="input" placeholder="Username" type="text"/>
    <input name="input" placeholder="Password" type="password"/>
    <input name="login" type="submit" value="Log in" />
  </div>
  <div id="footer">
    <a href="Home">Sign Up</a>
    <br />
    <a href="#">Forgot Password?</a>
  </div>
</div>
        </div>
    </form>
</body>
</html>
