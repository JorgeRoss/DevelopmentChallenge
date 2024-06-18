using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Helpers
{
    public static class Traducciones
    {
        private static readonly Dictionary<int, Dictionary<string, string>> TraduccionesPorIdioma = new Dictionary<int, Dictionary<string, string>>
        {
            {
                1, new Dictionary<string, string>
                {
                    { "Reporte", "Reporte de Formas" },
                    { "Vacio", "Lista vacía de formas!" },
                    { "Forma", "Forma" },
                    { "Cantidad", "Cantidad" },
                    { "Area", "Área" },
                    { "Perimetro", "Perímetro" },
                    { "Total", "Total" },
                    { "Cuadrado", "Cuadrado" },
                    { "Círculo", "Círculo" },
                    { "Triángulo", "Triángulo" },
                    { "Trapecio", "Trapecio" },
                    { "Rectangulo", "Rectangulo" }
                }
            },
            {
                2, new Dictionary<string, string>
                {
                    { "Reporte", "Shapes Report" },
                    { "Vacio", "Empty list of shapes!" },
                    { "Forma", "Shape" },
                    { "Cantidad", "Quantity" },
                    { "Area", "Area" },
                    { "Perimetro", "Perimeter" },
                    { "Total", "Total" },
                    { "Cuadrado", "Square" },
                    { "Círculo", "Circle" },
                    { "Triángulo", "Triangle" },
                    { "Trapecio", "Trapezoid" },
                    { "Rectangulo", "Rectangle" }
                }
            },
            {
                3, new Dictionary<string, string>
                {
                    { "Reporte", "Rapporto delle Forme" },
                    { "Vacio", "Lista vuota di forme!" },
                    { "Forma", "Forma" },
                    { "Cantidad", "Quantità" },
                    { "Area", "Area" },
                    { "Perimetro", "Perimetro" },
                    { "Total", "Totale" },
                    { "Cuadrado", "Quadrato" },
                    { "Círculo", "Cerchio" },
                    { "Triángulo", "Triangolo" },
                    { "Trapecio", "Trapezio" },
                    { "Rectangulo", "Rettangolo" }
                }
            }
        };

        public static string ObtenerTraduccion(int idioma, string termino)
        {
            if (TraduccionesPorIdioma.ContainsKey(idioma) && TraduccionesPorIdioma[idioma].ContainsKey(termino))
            {
                return TraduccionesPorIdioma[idioma][termino];
            }

            return termino;
        }
    }

}
