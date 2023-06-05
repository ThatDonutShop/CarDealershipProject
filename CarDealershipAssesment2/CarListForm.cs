using CarDealership.Core;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarDealership.WinForms
{
    public partial class CarListForm : Form
    {
        public CarListForm()
        {
            InitializeComponent();
        }

        private void CarListForm_Load(object sender, EventArgs e)
        {
            SearchBy.DataSource = new List<SearchOption>
            {
                new SearchOption("Make and Price", SearchType.MakeAndPriceRange),
                new SearchOption("Year", SearchType.Year)
            };

            SearchBy.SelectedIndex = 0;

            SearchByPriceFrom.Maximum = decimal.MaxValue;
            SearchByPriceFrom.Minimum = decimal.Zero;
            SearchByPriceTo.Maximum = decimal.MaxValue;
            SearchByPriceTo.Minimum = decimal.Zero;

            ConfigureSearchForm();
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
            if (ValidateCar())
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

        private void ValidateNotEmpty(object sender, CancelEventArgs e)
        {
            var input = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(input.Text))
            {
                carErrorProvider.SetError(input, "It can't be left empty");
            }
            else
            {
                carErrorProvider.SetError(input, string.Empty);
            }
        }

        private void ValidateYear(object sender, CancelEventArgs e)
        {
            var input = (TextBox)sender;

            if (new Regex("^(19|20)\\d{2}$").IsMatch(input.Text))
            {
                carErrorProvider.SetError(Year, string.Empty);

                var year = int.Parse(input.Text);

                if (year > DateTime.Now.Year)
                {
                    carErrorProvider.SetError(Year, $"The year cannot be greater than {DateTime.Now.Year}");
                }
            }
            else
            {
                carErrorProvider.SetError(Year, "Only valid years are allowed. Example: 2023");
            }
        }

        private void ValidatePrice(object sender, CancelEventArgs e)
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
                    carErrorProvider.SetError(input, "A price greater than zero is required.");
                }
            }
            else
            {
                carErrorProvider.SetError(input, "Only a valid price is allowed. Example 9,000");
            }
        }

        private bool ValidateCar()
        {
            var cancelArgs = new CancelEventArgs();

            ValidateNotEmpty(Make, cancelArgs);
            ValidateNotEmpty(Model, cancelArgs);
            ValidateYear(Year, cancelArgs);
            ValidatePrice(Price, cancelArgs);

            return carErrorProvider.HasErrors == false;
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
                    ClearCarList();
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
            var filteredCars = new List<Car>();

            switch (((SearchOption)SearchBy.SelectedItem).By)
            {
                case SearchType.Year:
                    filteredCars.AddRange(Filter.SearchForCarsSinceTheYear(
                        cars,
                        SearchByYear.Value.Year));

                    break;

                case SearchType.MakeAndPriceRange:
                    filteredCars.AddRange(Filter.SearchBy(
                        cars,
                        SearchByMake.Text,
                        SearchByPriceFrom.Value,
                        SearchByPriceTo.Value));

                    break;
            }

            if (ValidateSearch())
            {
                if (filteredCars.Any() == false)
                {
                    MessageBox.Show("No search results found");
                }
                else
                {
                    ClearCarList();

                    foreach (var car in filteredCars)
                    {
                        CarList.Items.Add(car);
                    }
                }
            }
        }

        private void ConfigureSearchForm()
        {
            var by = ((SearchOption)SearchBy.SelectedItem).By;

            SearchByYearPanel.Visible = by == SearchType.Year;
            MakeAndPriceRangePanel.Visible = by == SearchType.MakeAndPriceRange;
        }

        private void SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigureSearchForm();
        }

        private void ValidatePriceFromSearch(object sender, CancelEventArgs e)
        {
            var input = (NumericUpDown)sender;

            if (decimal.TryParse(input.Text, out decimal PriceFrom))
            {
                if (PriceFrom < decimal.Zero)
                {
                    searchErrorProvider.SetError(input, string.Empty);
                }
                else
                {
                    searchErrorProvider.SetError(input, "A price less than zero is not accepted.");
                }
            }
            else
            {
                searchErrorProvider.SetError(input, "Only a valid price is allowed. Example 9,000");
            }
        }

        private void ValidatePriceTo(object sender, CancelEventArgs e)
        {
            var input = (NumericUpDown)sender;

            if (decimal.TryParse(input.Text, out decimal PriceTo))
            {
                if (PriceTo < decimal.Zero)
                {
                    searchErrorProvider.SetError(input, string.Empty);
                }
                else
                {
                    searchErrorProvider.SetError(input, "A price less than zero is not accepted.");
                }
            }
            else
            {
                searchErrorProvider.SetError(input, "Only a valid price is allowed. Example 9,000");
            }
        }

        private bool ValidateSearch()
        {
            var cancelArgs = new CancelEventArgs();

            ValidatePriceFromSearch(SearchByPriceFrom, cancelArgs);
            ValidatePriceTo(SearchByPriceTo, cancelArgs);

            return carErrorProvider.HasErrors == false;
        }
    }
}
