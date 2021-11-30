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
    <a href="https://accounts.spotify.com/authorize?client_id=55f51ee8aa504686a72034c437db139d&amp;response_type=code&amp;scopes=playlist-read-private&amp;redirect_uri=https%3A%2F%2Flocalhost%3A44354%2FHome">Sign Up</a>
    <br />
    <a href="#">Forgot Password?</a>
  </div>
</div>
        </div>
    </form>
</body>
</html>
