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
    }
}