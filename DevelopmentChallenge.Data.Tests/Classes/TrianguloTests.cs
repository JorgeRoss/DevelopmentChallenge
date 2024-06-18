using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Classes
{
    [TestFixture]
    public class TrianguloTests
    {
        [Test]
        public void Triangulo_Area_OK()
        {
            var triangulo = new Triangulo(4, 3, 4, 3, 5);
            Assert.AreEqual(6, triangulo.Area);
        }

        [Test]
        public void Triangulo_Perimetro_OK()
        {
            var triangulo = new Triangulo(4, 3, 4, 3, 5);
            Assert.AreEqual(12, triangulo.Perimetro);
        }
    }
}
