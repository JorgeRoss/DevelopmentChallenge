using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes
{
    public class Triangulo : IFormaGeometrica
    {
        public double Base { get; private set; }
        public double Altura { get; private set; }
        public double Lado1 { get; private set; }
        public double Lado2 { get; private set; }
        public double Lado3 { get; private set; }
        public string Nombre => "Triángulo";

        public Triangulo(double baseTriangulo, double altura, double lado1, double lado2, double lado3)
        {
            Base = baseTriangulo;
            Altura = altura;
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public double Area => (Base * Altura) / 2;
        public double Perimetro => Lado1 + Lado2 + Lado3;
    }
}
