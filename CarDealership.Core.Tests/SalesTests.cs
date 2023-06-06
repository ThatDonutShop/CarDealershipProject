namespace CarDealership.Core.Tests
{
    public class SalesTests
    {
        [Fact]
        public void TaxPaymentIsCorrect()
        {
            var cars = new List<Car>
            {
                new Car { Price = 20000 },
                new Car { Price = 15000 }
            };
           
            decimal taxPayment = Sales.GetTaxPayment(cars);
           
            Assert.Equal(6650, taxPayment);
        }
    }
}