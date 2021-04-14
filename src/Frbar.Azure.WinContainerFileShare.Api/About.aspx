<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Frbar.Azure.WinContainerFileShare.Api.About" %>

<%@ Import Namespace="System.IO" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>

    <h2>File Share</h2>
    <pre><%: TreeStructure %></pre>
</asp:Content>
