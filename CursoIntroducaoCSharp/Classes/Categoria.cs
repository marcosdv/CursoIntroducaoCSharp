using System;

namespace CursoIntroducaoCSharp.Classes
{
    public class Categoria
    {
        DsGeralTableAdapters.TbCategoriaTableAdapter dsCategoria =
                                            new DsGeralTableAdapters.TbCategoriaTableAdapter();

        #region Atributos

        private int cat_codigo;
        private string cat_nome;

        public int catCodigo { get { return cat_codigo; } }

        public string catNome
        {
            get { return cat_nome;  }
            set { cat_nome = value; } 
        }

        #endregion

        #region Construtores

        public Categoria() { }

        public Categoria(int pCatCodigo)
        {
            DsGeral.TbCategoriaDataTable tbCategoria = new DsGeral.TbCategoriaDataTable();

            //dsCategoria.FillByCatCodigo(tbCategoria, pCatCodigo);
            tbCategoria = dsCategoria.GetDataByCatCodigo(pCatCodigo); 

            if (tbCategoria.Rows.Count > 0)
            {
                //cat_codigo = int.Parse(tbCategoria.Rows[0]["CatCodigo"].ToString());
                //cat_nome = tbCategoria.Rows[0]["CatNome"].ToString();

                DsGeral.TbCategoriaRow registro = (DsGeral.TbCategoriaRow)tbCategoria.Rows[0];
                cat_codigo = registro.CatCodigo;
                cat_nome = registro.CatNome;
            }
        }

        #endregion

        #region Manipulação de Dados

        public string salvar(int pCatCodigo, string pCatNome)
        {
            if (string.IsNullOrEmpty(pCatNome))
                return "O nome da categoria é obrigatório!";

            try
            {
                if (pCatCodigo > 0)
                    dsCategoria.Update(pCatNome, pCatCodigo);
                else
                    dsCategoria.Insert(pCatNome);
                
                return "";
            }
            catch (Exception e)
            {
                return "Erro ao salvar a categoria: " + e.Message;
            }
        }

        public string excluir(int pCatCodigo)
        {
            try
            {
                dsCategoria.Delete(pCatCodigo);
                return "";
            }
            catch (Exception e)
            {
                return "Erro ao excluir a categoria: " + e.Message;
            }
        }

        #endregion
    }
}