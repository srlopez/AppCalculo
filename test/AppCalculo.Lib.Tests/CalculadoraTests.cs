using Xunit;
using Calculo;


namespace Calculo
{
    public class CalculadoraTests : System.IDisposable
    {
        Calculadora cal;

        public CalculadoraTests()
        {
            this.cal = new Calculadora();
        }

        public void Dispose()
        {
            //_bar?.Dispose();
        }

        //[Fact]
        [Theory]
        [InlineData(6, 4, 2)]
        [InlineData(15, 12, 3)]
        [InlineData(12, 6, 6)]
        [InlineData(13, 11, 1)]
        public void MCD_Equal(int a, int b, int expected)
        {
            // Arrange
            // Act
            int result = cal.MCD(a, b);
            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 4, 3)]
        [InlineData(15, 12, 4)]
        [InlineData(12, 6, 3)]
        [InlineData(13, 11, 2)]
        public void MCD_NotEqual(int a, int b, int notExpeted)
        {
            // Arrange
            // Act
            int result = cal.MCD(a, b);
            // Assert
            Assert.NotEqual(notExpeted, result);
        }

        [Theory]
        [InlineData(6, 4, 12)]
        [InlineData(15, 10, 30)]
        [InlineData(12, 6, 12)]
        [InlineData(13, 11, 143)]
        public void MCM_Equal(int a, int b, int expected)
        {
            // Arrange
            // Act
            int result = cal.MCM(a, b);
            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 2, 3, 3)]
        [InlineData(1, 3, 2, 3)]
        [InlineData(2, 1, 3, 3)]
        [InlineData(2, 3, 1, 3)]
        [InlineData(3, 1, 2, 3)]
        [InlineData(3, 2, 1, 3)]
        public void Max_Equal(int a, int b, int c, int expected)
        {
            // Arrange
            // Act
            int result = cal.Max(a, b, c);
            // Assert
            Assert.Equal(expected, result);
        }
    
        [Theory]
        [InlineData(new int[]{1, 2, 3, 3}, "3/4")]
        [InlineData(new int[]{2, 2, 3}, "1/3")]
        public void Ejemplo1( int[] data, string expected){
            // Arrange
            // Act
            string result = cal.Ejemplo1(data);
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
