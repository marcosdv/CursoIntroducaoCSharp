<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="CursoIntroducaoCSharp.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Olá a todos" ToolTip="Sejam bem vindos"></asp:Label>
    </div>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Ola" OnClick="Button1_Click" CssClass="btn btn-secondary" />
    </p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Abastecer.aspx">Abastecer</asp:HyperLink>
        <br />
        <a id="link_padrao" href="Abastecer.aspx">Abastecer</a>
    </p>
</asp:Content>