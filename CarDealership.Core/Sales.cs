namespace CarDealership.Core
{
    public static class Sales
    {
        public static decimal GetAverageCarSalePriceIncludingGst(IEnumerable<Car> cars)
        {
            var prices = new List<decimal>();

            foreach (var car in cars)
            {
                prices.Add(car.TotalPrice);
            }

            if (prices.Count == 0)
            {
                return decimal.Zero;
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

            if (prices.Count == 0)
            {
                return decimal.Zero;
            }   

            return prices.Average();
        }
    }
}