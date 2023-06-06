using CarDealership.Core;
using System.ComponentModel;
using System.Text.RegularExpressions;

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

        private void OnLeave(object sender, EventArgs e)
        {
            var theControlBeingLeft = (Control)sender;

            if (string.IsNullOrEmpty(theControlBeingLeft.Text))
            {
                carErrorProvider.SetError(theControlBeingLeft, string.Empty);
            }
        }

        private bool ValidateNotEmpty(Control input)
        {
            if (string.IsNullOrWhiteSpace(input.Text))
            {
                carErrorProvider.SetError(input, "It can't be left empty");
            }
            else
            {
                carErrorProvider.SetError(input, string.Empty);
            }

            return carErrorProvider.GetError(input) == string.Empty;
        }

        private bool ValidateYear(Control input, ErrorProvider errorProvider)
        {
            if (new Regex("^(19|20)\\d{2}$").IsMatch(input.Text))
            {
                errorProvider.SetError(input, string.Empty);

                var year = int.Parse(input.Text);

                if (year > DateTime.Now.Year)
                {
                    errorProvider.SetError(input, $"The year cannot be greater than {DateTime.Now.Year}");
                }
            }
            else
            {
                errorProvider.SetError(input, "Only valid years are allowed. Example: 2023");
            }

            return errorProvider.GetError(input) == string.Empty;
        }

        private void ValidateYear(object sender, CancelEventArgs e)
        {
            if (Year.Text != string.Empty && ValidateYear(Year, carErrorProvider) == false)
            {
                e.Cancel = true;
            }
        }

        private void ValidateSearchingYear(object sender, CancelEventArgs e)
        {
            var input = (Control)sender;
            if (Year.Text != string.Empty && ValidateYear(input, searchErrorProvider) == false)
            {
                e.Cancel = true;
            }
        }

        private void ValidateSearchingPrice(object sender, CancelEventArgs e)
        {
            var input = (Control)sender;
            if (Year.Text != string.Empty && ValidatePrice(input, searchErrorProvider) == false)
            {
                e.Cancel = true;
            }
        }

        private bool ValidatePrice(Control input, ErrorProvider errorProvider)
        {
            if (decimal.TryParse(input.Text, out decimal price))
            {
                if (price > decimal.Zero)
                {
                    errorProvider.SetError(input, string.Empty);
                }
                else
                {
                    errorProvider.SetError(input, "A price greater than zero is required.");
                }
            }
            else
            {
                errorProvider.SetError(input, "Only a valid price is allowed. Example 9,000");
            }

            return errorProvider.GetError(input) == string.Empty;
        }

        private void ValidatePrice(object sender, CancelEventArgs e)
        {
            if (Price.Text != string.Empty && ValidatePrice(Price, carErrorProvider) == false)
            {
                e.Cancel = true;
            }
        }

        private bool ValidateCar()
        {
            return ValidateYear(Year, carErrorProvider) &
                ValidatePrice(Price, carErrorProvider) &
                ValidateNotEmpty(Make) &
                ValidateNotEmpty(Model);
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
            searchErrorProvider.Clear();

            var cars = CarList.Items.OfType<Car>();

            switch (((SearchOption)SearchBy.SelectedItem).By)
            {
                case SearchType.Year:

                    if (ValidateYear(SearchByYear, searchErrorProvider))
                    {
                        var carsSince = Filter.SearchForCarsSinceTheYear(cars, int.Parse(SearchByYear.Text));
                        ShowSearchResults(carsSince);
                    }
                    break;
                case SearchType.MakeAndPriceRange:
                    var canSearch = true;
                    
                    if (SearchPriceFrom.Text != string.Empty)
                    {
                        canSearch = ValidatePrice(SearchPriceFrom, searchErrorProvider);
                    }

                    if (SearchPriceTo.Text != string.Empty)
                    {
                        canSearch = ValidatePrice(SearchPriceTo, searchErrorProvider);
                    }

                    if (canSearch)
                    {
                        var make = SearchByMake.Text;
                        _ = decimal.TryParse(SearchPriceFrom.Text, out var from);
                        _ = decimal.TryParse(SearchPriceTo.Text, out var to);
                        var carsFound = Filter.SearchBy(cars, make, from, to);
                        ShowSearchResults(carsFound);
                    }

                    break;
            }
        }

        private void ShowSearchResults(IEnumerable<Car> filteredCars)
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

            ShowSaleStatistics();
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
    }
}
