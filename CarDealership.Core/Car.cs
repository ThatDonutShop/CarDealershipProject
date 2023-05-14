
namespace CarDealership.Core
{
    public sealed class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice => CalculateTotalPrice();

        private decimal CalculateTotalPrice() => Price * 15 / 100;
        
        public override string ToString()
        {
            return $"{Make,-10} {Model,-10} {Year,-10} {Price,-10:C} {TotalPrice,-10:C}";
        }

        public static Car Create(string make, string model, int year, decimal price)
        {
            return new Car 
            {
                Make = make,
                Model = model,
                Year = year,
                Price = price
            };
        }
    }
}