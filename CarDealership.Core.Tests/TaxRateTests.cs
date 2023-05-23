
namespace CarDealership.Core.Tests
{
    public class TaxRateTests
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 19999, 0)]
        [InlineData(1, 19999, 0.17)]
        [InlineData(1, 25000, 0.17)]
        [InlineData(1, 34999, 0.19)]
        [InlineData(80000, .01, .30)] // if greater than the highest bracked return highest rate.
        public void TaxRateCalculatedCorrect(decimal hondaPrice, decimal toyotaPrice, double expectedTaxRate)
        {
            var honda = new Car
            {
                Price = hondaPrice
            };

            var toyota = new Car
            {
                Price = toyotaPrice
            };

            var taxRate = TaxRates.Search(new[] { honda, toyota });

            Assert.Equal(expectedTaxRate, taxRate, 2);
        }
    }
}