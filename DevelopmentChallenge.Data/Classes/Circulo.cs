using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : IFormaGeometrica
    {
        public double Radio { get; set; }
        public string Nombre => "Círculo";

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double Area => Math.PI * Radio * Radio;
        public double Perimetro => 2 * Math.PI * Radio;
    }
}
