
namespace CarDealership.Core
{
    public sealed class Car
    {
        private const int Gst = 15;

        public string Make { get; set; } = default!;

        public string Model { get; set; } = default!;

        public int Year { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice
        {
            get
            {
                var gst = CalculateGst(Price);
                return Price + gst;
            }
        }

        public override string ToString()
        {
            return $"{Make,-15} {Model,-10} {Year,-10} {Price,-10:C} {TotalPrice :C}";
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

        private static decimal CalculateGst(decimal amount)
        {
            return amount * Gst / 100;
        }
    }
}