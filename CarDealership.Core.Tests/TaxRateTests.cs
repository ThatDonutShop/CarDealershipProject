
namespace CarDealership.Core.Tests
{
    public class TaxRateTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(19999, 0)]
        [InlineData(20000, 0.17)]
        [InlineData(25000, 0.17)]
        [InlineData(35000, 0.19)]
        [InlineData(80000, .30)]
        [InlineData(80000.01, .30)] 
        public void TaxRateCalculatedCorrect(decimal totalPrice, decimal expectedTaxRate)
        {
            var actualTaxRate = TaxRates.TaxRateSearching(totalPrice);
            Assert.Equal(expectedTaxRate, actualTaxRate, 2);
        }
    }
}