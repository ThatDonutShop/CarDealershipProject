using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Core
{
    public static class TaxRates
    {
        public static decimal Search(IEnumerable<Car> cars)
        {
            var totalPrice = decimal.Zero;

            foreach (var car in cars)
            {
                totalPrice += car.Price;
            }

            return totalPrice;
        }
    }
}
