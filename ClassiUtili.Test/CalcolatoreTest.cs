using Xunit;
using ClassiUtili;

namespace ClassiUtili.Test
{
    public class CalcolatoreTest
    {
        [Theory]
        [InlineData(7, -2, 5)]
        [InlineData(-7, -2, -9)]
        [InlineData(7, 0, 7)]
        [InlineData(-7, 2, -5)]
        [InlineData(0,0,0)]
        [InlineData(-double.MaxValue, 1000, -double.MaxValue)]
        public void Più_DovrebbeCalcolareValoriSemplici(double a, double b, double expected)
        {
            // Arrange (setup iniziale o precondizioni)

            // Act (funzionalità da testare o azioni)
            double actual = Calcolatore.Più(a, b);

            // Assert (risultato aspettato)
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Più_DovrebbeCalcolareValoriLimite()
        {
            // Arrange (setup iniziale o precondizioni)
            double expected = double.MaxValue;

            // Act (funzionalità da testare o azioni)
            double actual = Calcolatore.Più(double.MaxValue, 5);

            // Assert (risultato aspettato)
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, -2, -14)]
        [InlineData(-7, -2, 14)]
        [InlineData(7, 0, 0)]
        [InlineData(-7, 2, -14)]
        public void Per_DovrebbeCalcolareSempliciValori(double a, double b, double expected)
        {
            // Arrange (setup iniziale o precondizioni)

            // Act (funzionalità da testare o azioni)
            double actual = Calcolatore.Per(a, b);

            // Assert (risultato aspettato)
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Meno_DovrebbeCalcolareDifferenzaSempliciValori()
        {
            // Arrange (setup iniziale o precondizioni)
            double expected = -4;

            // Act (funzionalità da testare o azioni)
            double actual = Calcolatore.Meno(2, 6);

            // Assert (risultato aspettato)
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divisione_DivisionePerZero()
        {
            // Arrange (setup iniziale) 
            // BL Business Logic
            double expected = 0;

            // Act (funzionalità da testare o azioni)
            double actual = Calcolatore.Diviso(2, 0);

            // Assert (risultato aspettato)
            Assert.Equal(expected, actual);
        }
    }
}