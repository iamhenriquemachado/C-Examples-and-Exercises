namespace CSharpBasics.CSharp_POO.Week1.Imc_Calculator
{
    public class Imc
    {
        public double Weight { get; set; }
        public double Height { get; set; }

        private double result;

        public double CalculateImc(double weight, double height)
        {
            Weight = weight;
            Height = height;

            this.result = weight / Math.Pow(height, 2); 
            return result;
        }

        public override string ToString()
        {
            return "Your IMC is: " + result.ToString("F2");
        }
    }
}
