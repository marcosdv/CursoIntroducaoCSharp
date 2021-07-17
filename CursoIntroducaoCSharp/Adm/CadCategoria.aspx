<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/SiteAdm.Master" AutoEventWireup="true" CodeBehind="CadCategoria.aspx.cs" Inherits="CursoIntroducaoCSharp.Adm.CadCategoria" %>

<%@ Register Src="~/Adm/BarraEdicao.ascx" TagPrefix="uc1" TagName="BarraEdicao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cadastro de Categorias</h1>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <p>
                <asp:Button ID="btnListagem" runat="server" Text="Listagem" CssClass="btn btn-info" OnClick="btnListagem_Click" />
                <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-primary" OnClick="btnCadastro_Click" />
            </p>

            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="tabListagem" runat="server">
            
                    <asp:ObjectDataSource ID="ObjectDataSourceListagem" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="CursoIntroducaoCSharp.DsGeralTableAdapters.TbCategoriaTableAdapter"></asp:ObjectDataSource>
            
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
                        DataKeyNames="CatCodigo" DataSourceID="ObjectDataSourceListagem"
                        AllowSorting="true"
                        OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="CatCodigo" HeaderText="Código" InsertVisible="False"
                                ReadOnly="True" SortExpression="CatCodigo" />
                            
                            <asp:BoundField DataField="CatNome" HeaderText="Categoria"
                                SortExpression="CatNome" />
                            
                            <asp:CommandField HeaderText="Selecionar" SelectText="Selecionar"
                                ButtonType="Button" ShowSelectButton="true" ControlStyle-CssClass="btn btn-light" />
                        </Columns>
                    </asp:GridView>

                </asp:View>

                <asp:View ID="tabCadastro" runat="server">
                    <p><uc1:BarraEdicao runat="server" id="BarraEdicao" /></p>

                    <asp:HiddenField ID="campoCodigo" runat="server" />
            
                    Nome:<br />
                    <asp:TextBox ID="campoNome" runat="server" CssClass="form-control"></asp:TextBox>

                </asp:View>
            </asp:MultiView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
