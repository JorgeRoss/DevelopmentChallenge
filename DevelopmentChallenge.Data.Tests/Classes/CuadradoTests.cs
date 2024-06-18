using DevelopmentChallenge.Data.Classes;

namespace DevelopmentChallenge.Data.Tests.Classes
{
    [TestFixture]
    public class CuadradoTests
    {
        [Test]
        public void Cuadrado_Area_OK()
        {
            var cuadrado = new Cuadrado(4);
            Assert.AreEqual(16, cuadrado.Area);
        }

        [Test]
        public void Cuadrado_Perimetro_OK()
        {
            var cuadrado = new Cuadrado(4);
            Assert.AreEqual(16, cuadrado.Perimetro);
        }
    }
}
