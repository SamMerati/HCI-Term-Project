<%@ Page Title="Songs" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Songs.aspx.cs" Inherits="HCI_Term_Project.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3><%: Title %></h3>
    <h1>Liked Songs</h1>
    <p>A playlist including all of the users liked songs.</p>
    <asp:Table ID="Table1" runat="server"  Width="70%" HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" CellPadding="0" CellSpacing="0" GridLines="Horizontal">  
    <asp:TableRow runat="server">  
        <asp:TableCell runat="server">No.</asp:TableCell>  
        <asp:TableCell runat="server">Title</asp:TableCell>  
        <asp:TableCell runat="server">Album</asp:TableCell> 
        <asp:TableCell runat="server">Time</asp:TableCell>  
    </asp:TableRow>  
    <asp:TableRow runat="server">  
        <asp:TableCell runat="server">1</asp:TableCell>  
        <asp:TableCell runat="server">Song Number 1</asp:TableCell>  
        <asp:TableCell runat="server">Album NUmber 1</asp:TableCell>  
                <asp:TableCell runat="server">4:35</asp:TableCell>  

    </asp:TableRow>  
    <asp:TableRow runat="server">  
        <asp:TableCell runat="server">2</asp:TableCell>  
        <asp:TableCell runat="server"></asp:TableCell>  
        <asp:TableCell runat="server"></asp:TableCell>  
    </asp:TableRow>  
</asp:Table>
    </asp:Content>
