using DevelopmentChallenge.Data.Classes;

namespace DevelopmentChallenge.Data.Tests.Classes
{
    [TestFixture]
    public class RectanguloTests
    {
        [Test]
        public void Rectangulo_Area_OK()
        {
            var rectangulo = new Rectangulo(5, 10);
            Assert.AreEqual(50, rectangulo.Area);
        }

        [Test]
        public void Rectangulo_Perimetro_OK()
        {
            var rectangulo = new Rectangulo(5, 10);
            Assert.AreEqual(30, rectangulo.Perimetro);
        }
    }
}
