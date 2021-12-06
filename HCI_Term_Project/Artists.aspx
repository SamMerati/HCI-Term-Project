<%@ Page Title="Artists" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Artists.aspx.cs" Inherits="HCI_Term_Project.Artists" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h1 style="margin-left:200px"><%: Title %></h1>
    <br />
            <asp:Table ID="artistsTable" runat="server" CssClass="table">
                <asp:TableRow runat="server" HorizontalAlign="Left">
                    <asp:TableCell runat="server" Font-Size="20pt">Artists you follow</asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
</asp:Content>
