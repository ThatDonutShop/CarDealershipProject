
namespace CarDealership.Core
{
    public static class Filter
    {
        public static IEnumerable<Car> SearchByCarMake(IEnumerable<Car> cars, string make)
        {
            var foundCars = new List<Car>();

            foreach (var car in cars)
            {
                if (car.Make.Contains(make, StringComparison.OrdinalIgnoreCase))
                {
                    foundCars.Add(car);
                }
            }

            return foundCars;
        }

        public static IEnumerable<Car> SearchForCarsSinceTheYear(IEnumerable<Car> cars, int year)
        {
            var foundCars = new List<Car>();

            foreach (var car in cars)
            {
                if (car.Year > year)
                {
                    foundCars.Add(car);
                }
            }

            return foundCars;
        }

        public static IEnumerable<Car> SearchForCarsWithInthePriceRange(IEnumerable<Car> cars, decimal pricedFrom, decimal pricedTo)
        {
            var foundCars = new List<Car>();

            foreach (var car in cars)
            {
                if (car.Price >= pricedFrom && car.Price <= pricedTo)
                {
                    foundCars.Add(car);
                }
            }

            return foundCars;
        }

        public static IEnumerable<Car> SearchByCarMakeAndPriceRange(IEnumerable<Car> cars, string make, decimal pricedFrom, decimal pricedTo)
        {
            var carsByMake = SearchByCarMake(cars, make);
            var carsByPriceRange = SearchForCarsWithInthePriceRange(carsByMake, pricedFrom, pricedTo);
            return carsByPriceRange;
        }
    }
}
