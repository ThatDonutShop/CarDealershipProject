
namespace CarDealership.Core.Tests
{
    public class FilterCarTests
    {
        private const string HondaMake = "Honda";

        [Fact]
        public void CanFilterByCarsByHonda()
        {
            var cars = new List<Car>
            {
                new Car { Make = HondaMake, Price = 20000 },
                new Car { Make = "HoNda2", Price = 15000 },
                new Car { Make = "Holden", Price = 1}
            };

            var foundCars = Filter.SearchByCarMake(cars, HondaMake);

            Assert.All(foundCars, foundCar => Assert.StartsWith(
                HondaMake, 
                foundCar.Make,
                StringComparison.OrdinalIgnoreCase));
        }
    }
}