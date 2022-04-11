using Xunit;
using ClassiUtili;
using System;

namespace ClassiUtili.Test
{
    public class FrazioneTest
    {
        [Theory]
        [InlineData(100, 15)]
        [InlineData(-70, 22)]
        [InlineData(10, 3)]
        [InlineData(-100, -12)]
        [InlineData(1, -12)]
        public void IsDecimalePeriodico_DovrebbeEssereVero(int n, int d)
        {
            // Arrange (setup iniziale o precondizioni)
            Frazione f = new(n, d);

            // Act (funzionalità da testare o azioni)
            bool actual = f.IsDecimalePeriodico();

            // Assert (risultato aspettato)
            // Equal, True, False, Throws<TipoException>
            Assert.True(actual);
        }
        [Theory]
        [InlineData(66, -33)]
        [InlineData(3, 2)]
        [InlineData(11, -22)]
        [InlineData(0, -12)]
        public void IsDecimalePeriodico_DovrebbeEssereFalso(int n, int d)
        {
            // Arrange (setup iniziale o precondizioni)
            Frazione f = new(n, d);

            // Act (funzionalità da testare o azioni)
            bool actual = f.IsDecimalePeriodico();

            // Assert (risultato aspettato)
            Assert.False(actual);
        }
        [Theory]
        [InlineData(3, 25)]
        [InlineData(3, 2)]
        [InlineData(-30, 20)]
        [InlineData(-6, -40)]
        public void IsDecimaleFinito_DovrebbeEssereVero(int n, int d)
        {
            // Arrange (setup iniziale o precondizioni)
            Frazione f = new(n, d);
            char.IsAscii('d');
            // Act (funzionalità da testare o azioni)
            bool actual = f.IsDecimaleFinito();

            // Assert (risultato aspettato)
            Assert.True(actual);
        }
        [Theory]
        [InlineData(33, 14)]
        [InlineData(3, 1)]
        [InlineData(700, 70)]
        public void IsDecimaleFinito_DovrebbeEssereFalso(int n, int d)
        {
            // Arrange (setup iniziale o precondizioni)
            Frazione f = new(n, d);

            // Act (funzionalità da testare o azioni)
            bool actual = f.IsDecimaleFinito();

            // Assert (risultato aspettato)
            Assert.False(actual);
        }
        [Fact]
        public void OpeatorePiù_DovrebbeCalcolareFrazioneEIntero()
        {
            // Arrange (setup iniziale o precondizioni)
            var a = Frazione.Parse("7/2");
            int b = -2;
            Frazione expected = Frazione.Parse("3/2");
            // Act (funzionalità da testare o azioni)
            Frazione actual = a + b;

            // Assert (risultato aspettato)
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3, 9, 4, 6, 1, 1)]
        [InlineData(3, -2, -4, 6, -13, 6)]
        public void OpeatorePiù_DovrebbeCalcolareSempliciFrazioni(int f1N, int f1D, int f2N, int f2D, int expectedN, int expectedD)
        {
            // Arrange (setup iniziale o precondizioni)
            Frazione f1 = new(f1N, f1D);
            Frazione f2 = new(f2N, f2D);
            Frazione expected = new Frazione(expectedN, expectedD);
            // Act (funzionalità da testare o azioni)
            Frazione actual = (f1 + f2);

            // Assert (risultato aspettato)
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3, 1, 1, 4, 3, 4)]
        [InlineData(5, 1, 3, 7, 15, 7)]
        [InlineData(1, 3, 1, 4, 1, 12)]
        [InlineData(1, 5, 3, 7, 3, 35)]
        [InlineData(5, 6, 7, 8, 35, 48)]
        [InlineData(5, 6, 9, 20, 3, 8)]
        public void OpeatorePer_DovrebbeCalcolareSempliciFrazioni(int f1N, int f1D, int f2N, int f2D, int expectedN, int expectedD)
        {
            // Arrange (setup iniziale o precondizioni)
            Frazione f1 = new(f1N, f1D);
            Frazione f2 = new(f2N, f2D);
            Frazione expected = new Frazione(expectedN, expectedD);
            // Act (funzionalità da testare o azioni)
            Frazione actual = (f1 * f2);

            // Assert (risultato aspettato)
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("3,5", 7, 2)]
        [InlineData("0,4", 2, 5)]
        [InlineData("-0,01", -1, 100)]
        [InlineData("30", 30, 1)]
        [InlineData("0,1_1", 1, 9)]
        [InlineData("0,001_3", 1, 999)]
        [InlineData("1,23456_3", 123333, 99900)]
        [InlineData("2,23_1", 67, 30)]
        [InlineData("3/2", 3, 2)]
        [InlineData("3", 3, 1)]
        [InlineData("-30,50", -61, 2)]
        [InlineData("1,16_1", 7, 6)]
        public void Parse_DovrebbeCreareFrazioneDaStringa(string s, int expectedN, int expectedD)
        {
            // Arrange (setup iniziale o precondizioni)

            Frazione expected = Frazione.Parse(s);
            // Act (funzionalità da testare o azioni)
            Frazione actual = new(expectedN, expectedD);

            // Assert (risultato aspettato)
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3.5, 7, 2)]
        [InlineData(0.4, 2, 5)]
        [InlineData(-0.01, -1, 100)]
        [InlineData(30, 30, 1)]
        public void Frazione_DovrebbeCreareFrazioneDaDecimaleFinito(double decimaleFinito, int expectedN, int expectedD)
        {
            // Arrange (setup iniziale o precondizioni)

            Frazione expected = new(decimaleFinito);
            // Act (funzionalità da testare o azioni)
            Frazione actual = new(expectedN, expectedD);

            // Assert (risultato aspettato)
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(0.1, 1, 1, 9)]
        [InlineData(0.001, 3, 1, 999)]
        [InlineData(1.23456, 3, 123333, 99900)]
        [InlineData(2.23, 1, 67, 30)]
        public void Frazione_DovrebbeCreareFrazioneDaDecimalePeriodico(double decimalePeriodico, int periodo, int expectedN, int expectedD)
        {
            // Arrange (setup iniziale o precondizioni)

            Frazione expected = new(decimalePeriodico, periodo);
            // Act (funzionalità da testare o azioni)
            Frazione actual = new(expectedN, expectedD);

            // Assert (risultato aspettato)
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Frazione_DenominatoreDiversoDaZeroDovrebbeFunzionare()
        {
            // Act (funzionalità da testare o azioni)
            Frazione frazione = new Frazione(-21, 3);

            // Act (funzionalità da testare o azioni)
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