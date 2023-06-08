
namespace CarDealership.Core
{
    [Serializable]

    public sealed class Car
    {
        /// <summary>
        /// Sets up the vairables for Car
        /// </summary>
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

        /// <summary>
        /// creates a new car for the CarList
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <returns></returns>
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

        /// <summary>
        /// converts the car to a string format to display
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Make,-15} {Model,-10} {Year,-10} {Price,-10:C} {TotalPrice :C}";
        }

        /// <summary>
        /// calculates GST for TotalPrice
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        private static decimal CalculateGst(decimal amount)
        {
            return amount * Gst / 100;
        }
    }
}