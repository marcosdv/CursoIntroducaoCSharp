using System;

namespace CursoIntroducaoCSharp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Sejam bem vindos ao curso de introdução ao C#";
        }
    }
}