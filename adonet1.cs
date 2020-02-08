<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormdata.aspx.cs" Inherits="WebApDataOperations.WebFormdata" %>

<asp:Content ID="mycontent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotran">
        <asp:Label ID="Label1" runat="server" Text="Label">Id</asp:Label>
        <asp:TextBox ID="Id1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Label">Sname</asp:Label>
        <asp:TextBox ID="Sname1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>

        



    </div>
</asp:Content>