<%@ Page Title="Songs" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Songs.aspx.cs" Inherits="HCI_Term_Project.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3><%: Title %></h3>
    <h1>Liked Songs</h1>
    <p>Some of your top tracks!</p>
    <p>&nbsp;</p>
    <p>
        <asp:Table ID="songsTable" runat="server" CssClass="table">
            <asp:TableRow runat="server" HorizontalAlign="Center">
                <asp:TableCell runat="server">No.</asp:TableCell>
                <asp:TableCell runat="server">Title</asp:TableCell>
                <asp:TableCell runat="server">Artist</asp:TableCell>
                <asp:TableCell runat="server">Date Added</asp:TableCell>
                <asp:TableCell runat="server">Time (ms)</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </p>
    </asp:Content>
