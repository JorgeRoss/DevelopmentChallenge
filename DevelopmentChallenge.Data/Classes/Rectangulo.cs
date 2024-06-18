using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : IFormaGeometrica
    {
        public double Largo { get; }
        public double Ancho { get; }

        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public double Area => Largo * Ancho;
        public double Perimetro => 2 * (Largo + Ancho);
        public string Nombre => "Rectangulo";
    }
}
