<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Stanje.aspx.cs" Inherits="WebPresentationLayer.Stanje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class>
        <br />
        <br />
        <asp:Label ID="LabelStanjeMiker" runat="server" Text="Stanje maline sorte Miker:"></asp:Label>
        <asp:Label ID="LabelPrikazMiker" runat="server" Text=""></asp:Label>
        <br />
        <br />
         <asp:Label ID="LabelVilamet" runat="server" Text="Stanje maline sorte Vilamet:"></asp:Label>
        <asp:Label ID="LabelPrikazVilamet" runat="server" Text=""></asp:Label>
        <br />
        <br />

         <asp:Button ID="ButtonPrikaziMiker" runat="server" Text="Prikazi" OnClick="ButtonPrikaziMiker_Click" />
        
    </div>
    
</asp:Content>