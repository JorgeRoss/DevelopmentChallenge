using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : IFormaGeometrica
    {
        public double Lado { get; set; }
        public string Nombre => "Cuadrado";

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public double Area => Lado * Lado;
        public double Perimetro => 4 * Lado;
    }
}
