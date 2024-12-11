<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WingtipToys.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        instagram: flower_deep_<br />
        Bogotá, Colombia<br />
        <abbr title="Phone">P:</abbr>
        3143307128
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">flowerdeepSupport@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">flowerdeepMarketing@example.com</a>
    </address>
</asp:Content>
