using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;
using System;

namespace DevelopmentChallenge.Data.Tests.Classes
{
    [TestFixture]
    public class TrapecioTests
    {
        [Test]
        public void Trapecio_Area_OK()
        {
            var trapecio = new Trapecio(10, 5, 7, 5, 5, 7, 10);
            Assert.AreEqual(52.5, trapecio.Area);
        }

        [Test]
        public void Trapecio_Perimetro_OK()
        {
            var trapecio = new Trapecio(10, 5, 7, 5, 5, 7, 10);
            Assert.AreEqual(27, trapecio.Perimetro);
        }
    }
}
