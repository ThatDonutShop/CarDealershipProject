
namespace CarDealership.Core
{
    public static class TaxRates
    {
        public static double Search(IEnumerable<Car> cars)
        {
            decimal totalPrice = decimal.Zero;
            
            foreach (var car in cars)
            {
                totalPrice += car.Price;
            }

            return TaxRateSearching(totalPrice);
        }

        private static double TaxRateSearching(decimal totalPrice)
        {
            double[] taxRates = { 0.0, 0.17, 0.19, 0.21, 0.25, 0.30 };
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
