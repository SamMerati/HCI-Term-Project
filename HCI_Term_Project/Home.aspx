<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HCI_Term_Project._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Image ID="profilePic" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ImageAlign="Middle" />
&nbsp;<div class="stats">
            <h2 id="username">
                <asp:Label ID="usernameText" runat="server" Text="username"></asp:Label>
            </h2>
            <div class="user">
                <h4 id="label">Followers</h4>
                <h4>&nbsp;</h4>
                <asp:Label ID="followersText" runat="server" Text="0"></asp:Label>
            </div>
            <div class="user">
                <h4 id="label">Following</h4>
                <h4>&nbsp;</h4>
                <asp:Label ID="followingText" runat="server" Text="0"></asp:Label>
            </div>
            <div class="user">
                <h4 id="label">Playlists</h4>
                <h4>&nbsp;</h4>
            </div>
            <asp:Label ID="playlistsText" runat="server" Text="0"></asp:Label>
        </div>

    <table class="table">
  <thead>
    <tr>
      <th ID="blahblah" scope="col">#</th>
      <th scope="col">First</th>
      <th scope="col">Last</th>
      <th scope="col">Handle</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row">1</th>
      <td>Mark</td>
      <td>Otto</td>
      <td>@mdo</td>
    </tr>
    <tr>
      <th scope="row">2</th>
      <td>Jacob</td>
      <td>Thornton</td>
      <td>@fat</td>
    </tr>
    <tr>
      <th scope="row">3</th>
      <td>Larry</td>
      <td>the Bird</td>
      <td>@twitter</td>
    </tr>
  </tbody>
</table>
</asp:Content>
