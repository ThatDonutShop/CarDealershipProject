namespace CarDealership.Core
{
    public static class Sales
    {
        public static decimal GetTotalPriceExcludingGst(IEnumerable<Car> cars)
        {
            decimal totalPrice = decimal.Zero;

            foreach (var car in cars)
            {
                totalPrice += car.Price;
            }

            return totalPrice;
        }

        public static decimal GetTaxPayment(IEnumerable<Car> cars)
        {
            var totalPrice = GetTotalPriceExcludingGst(cars);
            var taxRate = TaxRates.TaxRateSearching(totalPrice);
            return totalPrice * taxRate;
        }    

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