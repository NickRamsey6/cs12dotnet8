using Ch04Ex02PrimeFactorsLib;

namespace Ch04Ex02PrimeFactorsTests
{
    public class PrimeFactorsUnitTests
    {
        [Fact]
        public void TestPrimeNumber()
        {
            // Arrange
            int inputNumber = 7;
            string expected = "Prime factor of 7 is 7";

            // Act
            string actual = Primes.PrimeFactors(inputNumber);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestPrimesOfFour()
        {
            // Arrange
            int inputNumber = 4;
            string expected = "2 x 2";

            // Act
            string actual = Primes.PrimeFactors(inputNumber);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestPrimesOfThirty()
        {
            // Arrange
            int inputNumber = 30;
            string expected = "5 x 3 x 2";

            // Act
            string actual = Primes.PrimeFactors(inputNumber);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestPrimesOfForty()
        {
            // Arrange
            int inputNumber = 40;
            string expected = "5 x 2 x 2 x 2";

            // Act
            string actual = Primes.PrimeFactors(inputNumber);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestPrimesOfFifty()
        {
            // Arrange
            int inputNumber = 50;
            string expected = "5 x 5 x 2";

            // Act
            string actual = Primes.PrimeFactors(inputNumber);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}