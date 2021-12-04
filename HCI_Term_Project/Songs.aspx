<%@ Page Title="Songs" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Songs.aspx.cs" Inherits="HCI_Term_Project.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3><%: Title %></h3>
    <h1>Liked Songs</h1>
    <p>Some of your top tracks!</p>
    <asp:Table ID="songsTable" runat="server" HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" CellPadding="0" CellSpacing="0" GridLines="Horizontal" CssClass="songsTable">  
    <asp:TableRow runat="server">  
        <asp:TableCell runat="server">No.</asp:TableCell>  
        <asp:TableCell runat="server">Title</asp:TableCell>  
        <asp:TableCell runat="server">Album</asp:TableCell> 
        <asp:TableCell runat="server">Time</asp:TableCell>  
    </asp:TableRow>  
</asp:Table>
    </asp:Content>
