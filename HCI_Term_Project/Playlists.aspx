<%@ Page Title="Playlists" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Playlists.aspx.cs" Inherits="HCI_Term_Project.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="margin-left:200px"><%: Title %></h1>
        <br />
    <p aria-multiselectable="False">
        <asp:Table ID="playlistTable" runat="server" CssClass="table">
            <asp:TableRow runat="server" HorizontalAlign="Left">
                <asp:TableCell runat="server" Font-Bold="False" Font-Size="20pt">Your Playlists</asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </p>
</asp:Content>
