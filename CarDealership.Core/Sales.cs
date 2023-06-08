namespace CarDealership.Core
{
    public static class Sales
    {
        /// <summary>
        /// every car on the list it will add and create a total price of all cars excluding gst
        /// </summary>
        /// <param name="cars"></param>
        /// <returns></returns>
        public static decimal GetTotalPriceExcludingGst(IEnumerable<Car> cars)
        {
            decimal totalPrice = decimal.Zero;

            foreach (var car in cars)
            {
                totalPrice += car.Price;
            }

            return totalPrice;
        }

        /// <summary>
        /// gets the tax payment using the total price of all cars and
        /// </summary>
        /// <param name="cars"></param>
        /// <returns></returns>
        public static decimal GetTaxPayment(IEnumerable<Car> cars)
        {
            var totalPrice = GetTotalPriceExcludingGst(cars);
            var taxRate = TaxRates.TaxRateSearching(totalPrice);
            return totalPrice * taxRate;
        }    

        /// <summary>
        /// gets every car price including gst and calculates the average price
        /// </summary>
        /// <param name="cars"></param>
        /// <returns></returns>
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

        /// <summary>
        /// gets every car price excluding gst and calculates the average price
        /// </summary>
        /// <param name="cars"></param>
        /// <returns></returns>
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