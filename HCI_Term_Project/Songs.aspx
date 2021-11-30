<%@ Page Title="Songs" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Songs.aspx.cs" Inherits="HCI_Term_Project.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3><%: Title %></h3>
    <h1>Liked Songs</h1>
    <p>A playlist including all of the users liked songs.</p>
    <asp:BulletedList ID="BulletedList1" runat="server" OnClick="BulletedList1_Click">
    </asp:BulletedList>
</asp:Content>
