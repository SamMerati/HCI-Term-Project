﻿<%@ Page Title="Playlists" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Playlists.aspx.cs" Inherits="HCI_Term_Project.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3><%: Title %></h3>
    <h1>Playlists</h1>
    <p aria-multiselectable="False">
        <asp:Label ID="playlistsItems" runat="server" Text="api"></asp:Label>
    </p>
    <p aria-multiselectable="False">&nbsp;</p>
</asp:Content>
