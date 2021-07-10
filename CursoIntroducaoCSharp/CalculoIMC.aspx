<%@ Page Title="Calcular IMC" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="CalculoIMC.aspx.cs" Inherits="CursoIntroducaoCSharp.CalculoIMC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Peso:" /><br />
                <asp:TextBox ID="edtPeso" runat="server" CssClass="form-control" />
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Altura:" /><br />
                <asp:TextBox ID="edtAltura" runat="server" CssClass="form-control" />
            </p>
            <p>
                <asp:Button ID="btnCalcular" runat="server" Text="Calcular" CssClass="btn btn-success" OnClick="btnCalcular_Click" />
            </p>
            <p class="alert alert-primary" id="painelResultado" runat="server" visible="false">
                <asp:Label ID="lblResultado" runat="server" Text="" />
            </p>
        </ContentTemplate>
    </asp:UpdatePanel>    
</asp:Content>