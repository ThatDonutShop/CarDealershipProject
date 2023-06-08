
namespace CarDealership.Core
{
    public static class Filter
    {
        /// <summary>
        /// Searches for the year inputed and gets all cars of the same year and above
        /// </summary>
        /// <param name="cars"></param>
        /// <param name="year"></param>
        /// <returns></returns>
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

        /// <summary>
        /// If priced from and priced to are more than 0 it will seach by them. if makes left empty it will only seach by the price range
        /// </summary>
        /// <param name="cars"></param>
        /// <param name="make"></param>
        /// <param name="pricedFrom"></param>
        /// <param name="pricedTo"></param>
        /// <returns></returns>
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

        /// <summary>
        /// searches by make and ignores casing and if it contains what 
        /// it was inputted it will show on the CarList
        /// </summary>
        /// <param name="cars"></param>
        /// <param name="make"></param>
        /// <returns></returns>
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

        /// <summary>
        /// searches for the cars within the price range
        /// </summary>
        /// <param name="cars"></param>
        /// <param name="pricedFrom"></param>
        /// <param name="pricedTo"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Searches both make and price range
        /// </summary>
        /// <param name="cars"></param>
        /// <param name="make"></param>
        /// <param name="pricedFrom"></param>
        /// <param name="pricedTo"></param>
        /// <returns></returns>
        public static IEnumerable<Car> SearchByCarMakeAndPriceRange(IEnumerable<Car> cars, string make, decimal pricedFrom, decimal pricedTo)
        {          
            var carsByMake = SearchByCarMake(cars, make);
            var carsByPriceRange = SearchForCarsWithInthePriceRange(carsByMake, pricedFrom, pricedTo);
            return carsByPriceRange;
        }
    }
}
