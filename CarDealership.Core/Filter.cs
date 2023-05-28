
namespace CarDealership.Core
{
    public static class Filter
    {
        public static IEnumerable<Car> SearchForCarsSinceTheYear(IEnumerable<Car> cars, int year)
        {
            var foundCars = new List<Car>();

            foreach (var car in cars)
            {
                if (car.Year >= year)
                {
                    foundCars.Add(car);
                }
            }

            return foundCars;
        }

        public static IEnumerable<Car> SearchBy(IEnumerable<Car> cars, string make, decimal pricedFrom, decimal pricedTo)
        {
            // all params to search are provided.
            if (string.IsNullOrWhiteSpace(make) == false && pricedFrom > 0 || pricedTo > 0)
            {
                return SearchByCarMakeAndPriceRange(cars, make, pricedFrom, pricedTo);
            }

            // check if we search by price.. or by make only.
            if (pricedFrom > 0 || pricedTo > 0)
            {
                return SearchForCarsWithInthePriceRange(cars, pricedFrom, pricedTo);
            }

            return SearchByCarMake(cars, make);
        }

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

        public static IEnumerable<Car> SearchForCarsWithInthePriceRange(IEnumerable<Car> cars, decimal pricedFrom, decimal pricedTo)
        {
            var foundCars = new List<Car>();

            foreach (var car in cars)
            {
                if ((pricedFrom == 0 || car.Price >= pricedFrom) && (pricedTo == 0 || car.Price <= pricedTo))
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
