using System.Xml.Linq;
using System;

namespace CarDealership.Core
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public decimal PriceIncGST { get; set; }


        public decimal CalculateGST()
        {
            decimal PriceGST = (Price * 15) / 100;
            PriceIncGST = PriceGST + Price;
            return PriceIncGST;
        }

        public override string ToString()
        {
            string ObjMsg = $"{Make,-10} {Model,-10}" + $"{Year,-10}"
                + $"{Price,-10:C}" + $"{PriceIncGST,-10:C}";
            return ObjMsg;
        }
    }
}