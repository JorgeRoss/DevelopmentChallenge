using DevelopmentChallenge.Data.Classes;

namespace DevelopmentChallenge.Data.Tests.Classes
{
    [TestFixture]
    public class CirculoTests
    {
        [Test]
        public void Circulo_Area_OK()
        {
            var circulo = new Circulo(3);
            Assert.AreEqual(Math.PI * 9, circulo.Area);
        }

        [Test]
        public void Circulo_Perimetro_OK()
        {
            var circulo = new Circulo(3);
            Assert.AreEqual(2 * Math.PI * 3, circulo.Perimetro);
        }
    }
}
