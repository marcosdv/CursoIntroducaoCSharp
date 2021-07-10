<%@ Page Title="O que abastecer?" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="Abastecer.aspx.cs" Inherits="CursoIntroducaoCSharp.Abastecer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Valor da Gasolina:" /><br />
                <asp:TextBox ID="edtGasolina" runat="server" CssClass="form-control" />
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Valor do Etanol:" /><br />
                <asp:TextBox ID="edtEtanol" runat="server" CssClass="form-control" />
            </p>
            <p>
                <asp:Button ID="btnCalcular" runat="server" Text="Calcular" CssClass="btn btn-primary" OnClick="btnCalcular_Click" />
            </p>
            <p class="alert alert-primary" id="painelResultado" runat="server" visible="false">
                <asp:Label ID="lblResultado" runat="server" Text="" />
            </p>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>