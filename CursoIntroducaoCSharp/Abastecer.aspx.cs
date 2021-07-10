using System;

namespace CursoIntroducaoCSharp
{
    public partial class Abastecer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorGasolina, valorEtanol;

            if (!double.TryParse(edtGasolina.Text, out valorGasolina))
            {
                lblResultado.Text = "Valor da gasolina digitado inválido!";
                painelResultado.Visible = true;
                return;
            }
            if (!double.TryParse(edtEtanol.Text, out valorEtanol))
            {
                lblResultado.Text = "Valor do etanol digitado inválido!";
                painelResultado.Visible = true;
                return;
            }

            string resultado;

            if (valorEtanol <= (valorGasolina * 0.7))
                resultado = "Etanol é mais vantajoso!";
            else
                resultado = "Gasolina é mais vantajoso!";

            lblResultado.Text = resultado;
            painelResultado.Visible = true;

            //ClientScript.RegisterStartupScript(this.GetType(), "meu_alerta", "alert('" + resultado + "');", true);
        }
    }
}