
namespace CarDealership.Core
{
    public static class TaxRates
    {
        public static double Search(IEnumerable<Car> cars)
        {
            double[] taxRates = { 0.0, 0.17, 0.19, 0.21, 0.25, 0.30 };
            decimal[] priceRanges = { 20000m, 35000m, 45000m, 60000m, 80000m };

            var totalPrice = cars.Select(car => car.Price).Sum();

            for (int i = 1; i < priceRanges.Length; i++)
            {
                if (totalPrice <= priceRanges[i])
                {
                    return taxRates[i];
                }
            }

            return taxRates[taxRates.Length - 1];
        }
    }
}
