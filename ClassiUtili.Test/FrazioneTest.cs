using Xunit;
using ClassiUtili;

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
        public void Frazione_ValidoDenominatoreDovrebbeFunzionare()
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


    }
}