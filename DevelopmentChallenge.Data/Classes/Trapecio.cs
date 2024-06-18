using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : IFormaGeometrica
    {
        public double BaseMayor { get; private set; }
        public double BaseMenor { get; private set; }
        public double Altura { get; private set; }
        public double Lado1 { get; private set; }
        public double Lado2 { get; private set; }
        public double Lado3 { get; private set; }
        public double Lado4 { get; private set; }
        public string Nombre => "Trapecio";

        public Trapecio(double baseMayor, double baseMenor, double altura, double lado1, double lado2, double lado3, double lado4)
        {
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Altura = altura;
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
            Lado4 = lado4;
        }

        public double Area => ((BaseMayor + BaseMenor) * Altura) / 2;
        public double Perimetro => Lado1 + Lado2 + Lado3 + Lado4;
    }
}
