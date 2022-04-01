using Xunit;
using ClassiUtili;
using System;

namespace ClassiUtili.Test
{
    public class FrazioneTest
    {
        [Fact]
        public void OpeatorePiù_DovrebbeCalcolareFrazioneEIntero()
        {
            // Arrange (setup iniziale)
            var a = new Frazione("7/2");
            int b = -2;
            Frazione expected = new Frazione("3/2");
            // Act (funzionalità da testare)
            Frazione actual = a + b;

            // Assert (risultato aspettato)
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3, 9, 4, 6, 1, 1)]
        [InlineData(3, -2, -4, 6, -13, 6)]
        public void OpeatorePiù_DovrebbeCalcolareSempliciFrazioni(int f1N, int f1D, int f2N, int f2D, int expectedN, int expectedD)
        {
            // Arrange (setup iniziale)
            Frazione f1 = new(f1N, f1D);
            Frazione f2 = new(f2N, f2D);
            Frazione expected = new Frazione(expectedN, expectedD);
            // Act (funzionalità da testare)
            Frazione actual = (f1 + f2);

            // Assert (risultato aspettato)
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void OpeatorePer_DovrebbeCalcolareSempliciFrazioni()
        {
            // Arrange (setup iniziale)
            var a = new Frazione("7/2");
            int b = -2;
            Frazione expected = new Frazione("-7");
            // Act (funzionalità da testare)
            Frazione actual = a * b;

            // Assert (risultato aspettato)
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Frazione_DenominatoreDiversoDaZeroDovrebbeFunzionare()
        {
            // Act (funzionalità da testare o azioni)
            Frazione frazione = new Frazione(-21, 3);

            // Assert (risultato aspettato)
            Assert.True(frazione.Denominatore != 0);
        }
        [Fact]
        public void Frazione_DenominatoreZeroDovrebbeFallire()
        {
            // Assert (risultato aspettato)
            Assert.Throws<ArgumentException>(() => new Frazione(5, 0));
        }
    }
}