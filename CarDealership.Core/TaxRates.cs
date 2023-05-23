
namespace CarDealership.Core
{
    public static class TaxRates
    {     
        public static decimal TaxRateSearching(decimal totalPrice)
        {
            decimal[] taxRates = { 0.0m, 0.17m, 0.19m, 0.21m, 0.25m, 0.30m };
            decimal[] priceRanges = { 20000m, 35000m, 45000m, 60000m, 80000m };

            for (int i = 0; i < priceRanges.Length; i++)
            {
                if (totalPrice < priceRanges[i])
                {
                    return taxRates[i];
                }
            }

            return taxRates[taxRates.Length - 1];
        }
    }
}
