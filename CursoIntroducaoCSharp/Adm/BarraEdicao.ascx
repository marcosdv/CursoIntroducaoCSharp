<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BarraEdicao.ascx.cs" Inherits="CursoIntroducaoCSharp.Adm.BarraEdicao" %>

<asp:Button ID="btnNovo" runat="server" Text="Novo" CssClass="btn btn-primary" />
<asp:Button ID="btnGravar" runat="server" Text="Gravar" CssClass="btn btn-success" />
<asp:Button ID="btnAlterar" runat="server" Text="Alterar" CssClass="btn btn-warning" />
<asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-dark" />
<asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn btn-danger"
    OnClientClick="return confirm('Deseja realmente excluir esse registro?');" />