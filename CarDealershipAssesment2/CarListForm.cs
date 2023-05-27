using CarDealership.Core;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
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
                ClearInputs();
            }
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            ClearCarList();
        }

        private void ClearCarList()
        {
            CarList.Items.Clear();

            ShowSaleStatistics();
        }

        private void ShowSaleStatistics()
        {
            var cars = CarList.Items.OfType<Car>();
            AverageCarSalesIncludingGst.Text = Sales.GetAverageCarSalePriceIncludingGst(cars).ToString("C");
            AverageCarSalesExcludingGst.Text = Sales.GetAverageCarSalePriceExcludingGst(cars).ToString("C");
            TaxPayment.Text = Sales.GetTaxPayment(cars).ToString("C");
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

        private async void SaveFile_Click(object sender, EventArgs e)
        {
            var cars = CarList.Items.OfType<Car>();

            if (cars.Any())
            {
                var saved = await FileManager.Save(cars);

                if (saved)
                {
                    MessageBox.Show("Saved cars", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to save cars", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void LoadFile_Click(object sender, EventArgs e)
        {
            CarList.Items.Clear();

            foreach (var car in await FileManager.Load())
            {
                CarList.Items.Add(car);
            }

            ShowSaleStatistics();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var cars = CarList.Items.OfType<Car>();
            IEnumerable<Car> filteredCars = Enumerable.Empty<Car>();

            switch (SearchBy.SelectedItem)
            {
                case "Year":
                    filteredCars = Filter.SearchForCarsSinceTheYear(cars, SearchByYear.Value.Year);
                    break;

                case "Make And Price":

                    if (SearchByMake.Text != string.Empty)
                    {

                    }
                    
                    filteredCars = Filter.SearchByCarMakeAndPriceRange(
                        cars,
                        SearchByMake.Text,
                        SearchByPriceFrom.Value,
                        SearchByPriceTo.Value);

                    break;
            }

            ClearCarList();

            foreach (var car in filteredCars)
            {
                CarList.Items.Add(car);
            }

            if (CarList.Items.Count == 0) 
            {
                MessageBox.Show("No search results found");
            }
        }

        private void ConfigureSearchForm()
        {
            switch (SearchBy.SelectedItem)
            {
                case "Make And Price":
                    MakeAndPriceRangePanel.Visible = true;
                    SearchByYearPanel.Visible = false;
                    break;

                case "Year":
                    SearchByYearPanel.Visible = true;
                    MakeAndPriceRangePanel.Visible = false;
                    break;

                default:
                    SearchByYearPanel.Visible = false;
                    MakeAndPriceRangePanel.Visible = false;
                    break;
            }
        }

        private void SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigureSearchForm();
        }

        private void CarListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
