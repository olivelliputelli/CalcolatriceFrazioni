using Xunit;
using ClassiUtili;
using System;

namespace ClassiUtili.Test
{
    public class FrazioneTest
    {
        [Fact]
        public void OpeatorePiù_DovrebbeCalcolareSempliciFrazioni()
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
            // Arrange (setup iniziale o precondizioni)

            // Act (funzionalità da testare o azioni)
            Frazione frazione = new Frazione(-21, 3);

            // Assert (risultato aspettato)
            Assert.True(frazione.Denominatore != 0);
        }
        [Fact]
        public void Frazione_DenominatoreZeroDovrebbeFallire()
        {
            // Arrange (setup iniziale o precondizioni)

            // Act (funzionalità da testare o azioni)

            // Assert (risultato aspettato)
            Assert.Throws<ArgumentException>(() => new Frazione(5, 0));
        }
    }
}