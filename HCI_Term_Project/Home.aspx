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
    <br />
        <br />

                <asp:Image ID="currentImage" runat="server" Height="75px" Width="75px" />
                <asp:Label ID="currentSong" runat="server" Font-Size="20pt" ForeColor="Black" Text="Current Song Playing"></asp:Label>
                <br>
                <asp:Button ID="backButton" runat="server" Text="⏮" Width="15%" BackColor="White" BorderColor="Black" BorderStyle="None" Font-Size="50pt"/>
                <asp:Button ID="playButton" runat="server" Text="▶️" Width="15%" BackColor="White" BorderColor="Black" BorderStyle="None" Font-Size="50pt" OnClick="playButton_Click"/>
                <asp:Button ID="forwardButton" runat="server" Text="⏭" Width="15%" BackColor="White" BorderStyle="None" Font-Size="50pt" BorderColor="Black"/>
</asp:Content>
