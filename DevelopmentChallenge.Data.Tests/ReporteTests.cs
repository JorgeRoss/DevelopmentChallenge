using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.UsesCases;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class ReporteTests
    {
        [Test]
        public void Imprimir_ReporteEnEspanol_OK()
        {
            var formas = new List<IFormaGeometrica>
        {
            new Cuadrado(5),
            new Cuadrado(10),
            new Circulo(3),
            new Triangulo(5, 10, 5, 5, 5),
            new Trapecio(10, 5, 7, 5, 5, 7, 10)
        };

            var reporte = Reporte.Imprimir(formas, 1);

            var expectedReport = "<h1>Reporte de Formas</h1><br/>Cuadrado: 2 | Área: 125 | Perímetro: 60<br/>Círculo: 1 | Área: 28.27 | Perímetro: 18.85<br/>Triángulo: 1 | Área: 25 | Perímetro: 15<br/>Trapecio: 1 | Área: 52.5 | Perímetro: 27<br/>Total: 5<br/> | Área: 230.77 | Perímetro: 120.85";

            Assert.AreEqual(expectedReport, reporte);
        }

        [Test]
        public void Imprimir_ReporteEnIngles_OK()
        {
            var formas = new List<IFormaGeometrica>
        {
            new Cuadrado(5),
            new Cuadrado(10),
            new Circulo(3),
            new Triangulo(5, 10, 5, 5, 5),
            new Trapecio(10, 5, 7, 5, 5, 7, 10)
        };

            var reporte = Reporte.Imprimir(formas, 2);

            var expectedReport = "<h1>Shapes Report</h1><br/>Square: 2 | Area: 125 | Perimeter: 60<br/>Circle: 1 | Area: 28.27 | Perimeter: 18.85<br/>Triangle: 1 | Area: 25 | Perimeter: 15<br/>Trapezoid: 1 | Area: 52.5 | Perimeter: 27<br/>Total: 5<br/> | Area: 230.77 | Perimeter: 120.85";

            Assert.AreEqual(expectedReport, reporte);
        }

        [Test]
        public void Imprimir_SinFormas_OK()
        {
            var formas = new List<IFormaGeometrica>();

            var reporte = Reporte.Imprimir(formas, 1);

            var expectedReport = "<h1>Reporte de Formas</h1><br/>Lista vacía de formas!";

            Assert.AreEqual(expectedReport, reporte);
        }

        [Test]
        public void Imprimir_ReporteConRectanguloEnEspanol_OK()
        {
            var formas = new List<IFormaGeometrica>
        {
            new Cuadrado(5),
            new Rectangulo(5, 10),
            new Circulo(3),
            new Triangulo(5, 10, 5, 5, 5),
            new Trapecio(10, 5, 7, 5, 5, 7, 10)
        };

            var reporte = Reporte.Imprimir(formas, 1);

            var expectedReport = "<h1>Reporte de Formas</h1><br/>Cuadrado: 1 | Área: 25 | Perímetro: 20<br/>Rectangulo: 1 | Área: 50 | Perímetro: 30<br/>Círculo: 1 | Área: 28.27 | Perímetro: 18.85<br/>Triángulo: 1 | Área: 25 | Perímetro: 15<br/>Trapecio: 1 | Área: 52.5 | Perímetro: 27<br/>Total: 5<br/> | Área: 180.77 | Perímetro: 110.85";

            Assert.AreEqual(expectedReport, reporte);
        }

        [Test]
        public void Imprimir_ReporteConRectanguloEnIngles_OK()
        {
            var formas = new List<IFormaGeometrica>
        {
            new Cuadrado(5),
            new Rectangulo(5, 10),
            new Circulo(3),
            new Triangulo(5, 10, 5, 5, 5),
            new Trapecio(10, 5, 7, 5, 5, 7, 10)
        };

            var reporte = Reporte.Imprimir(formas, 2);
            var expectedReport = "<h1>Shapes Report</h1><br/>Square: 1 | Area: 25 | Perimeter: 20<br/>Rectangle: 1 | Area: 50 | Perimeter: 30<br/>Circle: 1 | Area: 28.27 | Perimeter: 18.85<br/>Triangle: 1 | Area: 25 | Perimeter: 15<br/>Trapezoid: 1 | Area: 52.5 | Perimeter: 27<br/>Total: 5<br/> | Area: 180.77 | Perimeter: 110.85";

            Assert.AreEqual(expectedReport, reporte);
        }

        [Test]
        public void Imprimir_ReporteRectanguloEnEnItaliano_OK()
        {
            var formas = new List<IFormaGeometrica>
        {
            new Cuadrado(5),
            new Rectangulo(5, 10),
            new Circulo(3),
            new Triangulo(5, 10, 5, 5, 5),
            new Trapecio(10, 5, 7, 5, 5, 7, 10)
        };

            var reporte = Reporte.Imprimir(formas, 3);
            var expectedReport = "<h1>Rapporto delle Forme</h1><br/>Quadrato: 1 | Area: 25 | Perimetro: 20<br/>Rettangolo: 1 | Area: 50 | Perimetro: 30<br/>Cerchio: 1 | Area: 28.27 | Perimetro: 18.85<br/>Triangolo: 1 | Area: 25 | Perimetro: 15<br/>Trapezio: 1 | Area: 52.5 | Perimetro: 27<br/>Totale: 5<br/> | Area: 180.77 | Perimetro: 110.85";

            Assert.AreEqual(expectedReport, reporte);
        }
    }
}
