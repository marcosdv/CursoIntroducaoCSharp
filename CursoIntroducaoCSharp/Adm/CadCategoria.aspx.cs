using CursoIntroducaoCSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CursoIntroducaoCSharp.Adm
{
    public partial class CadCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
                habilitaCampos(false);
            }

            BarraEdicao.BtnNovo.Click += new EventHandler(btnNovo_Click);
            BarraEdicao.BtnAlterar.Click += new EventHandler(btnAlterar_Click);
            BarraEdicao.BtnCancelar.Click += new EventHandler(btnCancelar_Click);
            BarraEdicao.BtnExcluir.Click += new EventHandler(btnExcluir_Click);
            BarraEdicao.BtnGravar.Click += new EventHandler(btnSalvar_Click);
        }

        protected void btnListagem_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        private void atualizarCampos(int iCodigo)
        {
            if (iCodigo > 0)
            {
                Categoria cat = new Categoria(iCodigo);
                campoCodigo.Value = cat.catCodigo.ToString();
                campoNome.Text = cat.catNome;
            }
            else
            {
                campoCodigo.Value = "0";
                campoNome.Text = "";
            }
        }

        private void habilitaCampos(bool habilitar)
        {
            campoNome.Enabled = habilitar;
            BarraEdicao.BtnGravar.Enabled = habilitar;
            BarraEdicao.BtnCancelar.Enabled = habilitar;

            habilitar = !habilitar;

            BarraEdicao.BtnNovo.Enabled = habilitar;
            BarraEdicao.BtnAlterar.Enabled = habilitar;
            BarraEdicao.BtnExcluir.Enabled = habilitar;
        }

        private int getCodigoSelecionado()
        {
            if (GridView1.SelectedDataKey == null)
                return 0;
            else
                return int.Parse(GridView1.SelectedDataKey[0].ToString());
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            atualizarCampos(0);
            habilitaCampos(true);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!campoCodigo.Equals("0"))
                habilitaCampos(true);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            atualizarCampos(getCodigoSelecionado());
            habilitaCampos(false);

            btnListagem_Click(sender, e);
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            string retorno = cat.excluir(int.Parse(campoCodigo.Value));

            if (string.IsNullOrEmpty(retorno))
            {
                atualizarCampos(0);
                ObjectDataSourceListagem.DataBind();
                GridView1.DataBind();

                btnListagem_Click(sender, e);
            }
            else
            {
                mostrarMensagem(retorno);
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            string retorno = cat.salvar(int.Parse(campoCodigo.Value), campoNome.Text);

            if (string.IsNullOrEmpty(retorno))
            {
                mostrarMensagem("Categoria salva com sucesso!");
                atualizarCampos(getCodigoSelecionado());
                habilitaCampos(false);

                ObjectDataSourceListagem.DataBind();
                GridView1.DataBind();

                btnListagem_Click(sender, e);
            }
            else
            {
                mostrarMensagem(retorno);
            }
        }

        private void  mostrarMensagem(string mensagem)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(),
                Guid.NewGuid().ToString(), "alert('" + mensagem + "');", true);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizarCampos(getCodigoSelecionado());
            btnCadastro_Click(sender, e);
        }
    }
}