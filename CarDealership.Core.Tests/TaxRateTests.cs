
namespace CarDealership.Core.Tests
{
    public class TaxRateTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(19999, 0)]
        [InlineData(20000, 0.17)]
        [InlineData(34999, 0.17)]
        [InlineData(35000, 0.19)]
        [InlineData(44999, 0.19)]
        [InlineData(45000, 0.21)]
        [InlineData(59999, 0.21)]
        [InlineData(60000, 0.25)]
        [InlineData(79999, 0.25)]
        [InlineData(80000, .30)]
        [InlineData(80001, .30)] 
        public void TaxRateCalculatedCorrect(decimal totalPrice, decimal expectedTaxRate)
        {
            var actualTaxRate = TaxRates.TaxRateSearching(totalPrice);
            Assert.Equal(expectedTaxRate, actualTaxRate, 2);
        }
    }
}