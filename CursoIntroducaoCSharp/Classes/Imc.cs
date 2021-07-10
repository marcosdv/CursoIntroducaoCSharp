namespace CursoIntroducaoCSharp.Classes
{
    public class Imc
    {
        private double peso, altura;

        public Imc(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public string getResultado()
        {
            double imc = peso / (altura * altura);

            //if ((imc > 18.5) && (imc < 25))
            //    return "Peso normal";

            switch (imc)
            {
                case var _ when imc <= 18.5:
                    return "Peso abaixo do normal";
                case var _ when imc > 18.5 && imc < 25:
                    return "Peso normal";
                case var _ when imc >= 25 && imc < 30:
                    return "Sobre peso";
                case var _ when imc >= 30 && imc < 35:
                    return "Grau de obesidade I";
                case var _ when imc >= 35 && imc < 40:
                    return "Grau de obesidade II";
                case var _ when imc >= 40:
                    return "Grau de obesidade III";
                default:
                    return "";
            }
        }
    }
}