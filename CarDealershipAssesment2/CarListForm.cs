using CarDealership.Core;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CarDealership.WinForms
{
    public partial class CarListForm : Form
    {
        public CarListForm()
        {
            InitializeComponent();
        }

        private void ClearInputs()
        {
            Make.Text = string.Empty;
            Model.Text = string.Empty;
            Year.Text = string.Empty;
            Price.Text = string.Empty;
        }

        private void AddToList_OnClick(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var year = int.Parse(Year.Text);
                var price = decimal.Parse(Price.Text);
                var car = Car.Create(Make.Text, Model.Text, year, price);

                CarList.Items.Add(car);

                ShowSaleStatistics();
                CalculateTaxRate();
                ClearInputs();
            }
        }
        private void ClearList_Click(object sender, EventArgs e)
        {
            CarList.Items.Clear();

            ShowSaleStatistics();
            CalculateTaxRate();
        }

        private void CalculateTaxRate()
        {
            var taxRate = TaxRates.Search(CarList.Items.OfType<Car>());
            TaxRate.Text = taxRate.ToString("C");
        }

        private void ShowSaleStatistics()
        {
            var cars = CarList.Items.OfType<Car>();
            AverageCarSalesIncludingGst.Text = Sales.GetAverageCarSalePriceIncludingGst(cars).ToString("C");
            AverageCarSalesExcludingGst.Text = Sales.GetAverageCarSalePriceExcludingGst(cars).ToString("C");
        }

        private void ValidateNotEmpty(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var input = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(input.Text))
            {
                carErrorProvider.SetError(input, "It can't be left empty");
                e.Cancel = true;
            }
            else
            {
                carErrorProvider.SetError(input, string.Empty);
            }
        }

        /// <summary>
        /// Validate the year of the car using a regular expression"
        /// https://stackoverflow.com/questions/4374185/regular-expression-match-to-test-for-a-valid-year
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateYear(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var input = (TextBox)sender;

            if (new Regex("^(19|20)\\d{2}$").IsMatch(input.Text))
            {
                carErrorProvider.SetError(Year, string.Empty);

                var year = int.Parse(input.Text);

                if (year > DateTime.Now.Year)
                {
                    e.Cancel = true;
                    carErrorProvider.SetError(Year, $"The year cannot be greater than {DateTime.Now.Year}");
                }
            }
            else
            {
                e.Cancel = true;
                carErrorProvider.SetError(Year, "Only valid years are allowed. Example: 2023");
            }
        }

        private void ValidatePrice(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var input = (TextBox)sender;

            if (decimal.TryParse(input.Text, out decimal price))
            {
                if (price > decimal.Zero)
                {
                    carErrorProvider.SetError(input, string.Empty);
                }
                else
                {
                    e.Cancel = true;
                    carErrorProvider.SetError(input, "A price greater than zero is required.");
                }
            }
            else
            {
                e.Cancel = true;
                carErrorProvider.SetError(input, "Only a valid price is allowed. Example 9,000");
            }
        }
    }
}