using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.UsesCases;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [Test]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Reporte de Formas</h1><br/>Lista vacía de formas!",
                Reporte.Imprimir(new List<IFormaGeometrica>(), 1));
        }

        [Test]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Shapes Report</h1><br/>Empty list of shapes!",
                Reporte.Imprimir(new List<IFormaGeometrica>(), 2));
        }

        [Test]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };

            var resumen = Reporte.Imprimir(cuadrados, 1);

            Assert.AreEqual("<h1>Reporte de Formas</h1><br/>Cuadrado: 1 | Área: 25 | Perímetro: 20<br/>Total: 1<br/> | Área: 25 | Perímetro: 20", resumen);
        }

        [Test]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IFormaGeometrica>
                    {
                        new Cuadrado(5),
                        new Cuadrado(1),
                        new Cuadrado(3)
                    };

            var resumen = Reporte.Imprimir(cuadrados, 2);

            Assert.AreEqual("<h1>Shapes Report</h1><br/>Square: 3 | Area: 35 | Perimeter: 36<br/>Total: 3<br/> | Area: 35 | Perimeter: 36", resumen);
        }

        [Test]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<IFormaGeometrica>
                    {
                        new Cuadrado(5),
                        new Circulo(3),
                        new Triangulo(5, 10, 4, 4, 4),
                        new Cuadrado(2),
                        new Triangulo(5, 10, 9, 9, 9),
                        new Circulo(2.75),
                        new Triangulo(5, 10, 4.2, 4.2, 4.2)
                    };

            var resumen = Reporte.Imprimir(formas, 2);

            Assert.AreEqual(
                "<h1>Shapes Report</h1><br/>Square: 2 | Area: 29 | Perimeter: 28<br/>Circle: 2 | Area: 52.03 | Perimeter: 36.13<br/>Triangle: 3 | Area: 75 | Perimeter: 51.6<br/>Total: 7<br/> | Area: 156.03 | Perimeter: 115.73",
                resumen);
        }

        [Test]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
                    {
                        new Cuadrado(5),
                        new Circulo(3),
                        new Triangulo(5, 10, 4, 4, 4),
                        new Cuadrado(2),
                        new Triangulo(5, 10, 9, 9, 9),
                        new Circulo(2.75),
                        new Triangulo(5, 10, 4.2, 4.2, 4.2)
                    };

            var resumen = Reporte.Imprimir(formas, 1);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1><br/>Cuadrado: 2 | Área: 29 | Perímetro: 28<br/>Círculo: 2 | Área: 52.03 | Perímetro: 36.13<br/>Triángulo: 3 | Área: 75 | Perímetro: 51.6<br/>Total: 7<br/> | Área: 156.03 | Perímetro: 115.73",
                resumen);
        }
    }
}
