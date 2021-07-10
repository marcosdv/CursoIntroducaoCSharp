using CursoIntroducaoCSharp.Classes;
using System;

namespace CursoIntroducaoCSharp
{
    public partial class CalculoIMC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura;

            if (!double.TryParse(edtPeso.Text, out peso))
            {
                lblResultado.Text = "Peso digitado inválido!";
                painelResultado.Visible = true;
                return;
            }
            if (!double.TryParse(edtAltura.Text, out altura))
            {
                lblResultado.Text = "Altura digitada inválida!";
                painelResultado.Visible = true;
                return;
            }

            //Imc imc = new Imc(peso, altura);

            lblResultado.Text = new Imc(peso, altura).getResultado();
            painelResultado.Visible = true;
        }
    }
}