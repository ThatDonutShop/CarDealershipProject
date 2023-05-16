using CarDealership.Core;

namespace CarDealershipAssesment2
{
    public static class CarSales
    {
        public static decimal GetAverageCarSalePriceIncludingGst(IEnumerable<Car> cars)
        {
            var prices = new List<decimal>();

            foreach (var car in cars)
            {
                prices.Add(car.TotalPrice);
            }

            return prices.Average();
        }

        public static decimal GetAverageCarSalePriceExcludingGst(IEnumerable<Car> cars)
        {
            var prices = new List<decimal>();

            foreach (var car in cars)
            {
                prices.Add(car.Price);
            }

            return prices.Average();
        }
    }
}