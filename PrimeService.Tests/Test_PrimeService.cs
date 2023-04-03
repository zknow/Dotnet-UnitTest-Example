using Xunit;

namespace Prime.UnitTests
{
    public class Test_PrimeService
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        [Theory]
        [InlineData(10, 20, 30)]
        [InlineData(5, 10, 15)]
        public void MyTestMethod(int a, int b, int expected)
        {
            int result = a + b;
            Assert.Equal(expected, result);
        }
    }
}