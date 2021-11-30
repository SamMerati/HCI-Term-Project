<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HCI_Term_Project._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <img alt="" src="Images/robot.jpg" id="profilePic"/>
    <div class="stats">
            <h2 id="username">Test User</h2>
            <div class="user">
                <h4 id="label">Followers</h4>
                <h4>12</h4>
            </div>
            <div class="user">
                <h4 id="label">Following</h4>
                <h4>7</h4>
            </div>
            <div class="user">
                <h4 id="label">Playlists</h4>
                <h4>28</h4>
            </div>
        </div>
</asp:Content>
