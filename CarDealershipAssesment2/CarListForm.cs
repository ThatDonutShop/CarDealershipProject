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

        /// <summary>
        /// When the form loads it will set up the search options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Clears inputs for adding to CarList
        /// </summary>
        private void ClearInputs()
        {
            Make.Text = string.Empty;
            Model.Text = string.Empty;
            Year.Text = string.Empty;
            Price.Text = string.Empty;
        }

        /// <summary>
        /// When you add to list if valid it will add them to the CarList listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// clears the CarList listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearList_Click(object sender, EventArgs e)
        {
            ClearCarList();
        }

        /// <summary>
        /// Clears CarList and the sale stats (TaxRate, and average sale prices)
        /// </summary>
        private void ClearCarList()
        {
            CarList.Items.Clear();

            ShowSaleStatistics();
        }

        /// <summary>
        /// Shows the sale statistics and converts them to "C" (currency)
        /// </summary>
        private void ShowSaleStatistics()
        {
            var cars = CarList.Items.OfType<Car>();
            AverageCarSalesIncludingGst.Text = Sales.GetAverageCarSalePriceIncludingGst(cars).ToString("C");
            AverageCarSalesExcludingGst.Text = Sales.GetAverageCarSalePriceExcludingGst(cars).ToString("C");
            TaxPayment.Text = Sales.GetTaxPayment(cars).ToString("C");
        }

        /// <summary>
        /// When in a textBox for adding to list such as year if its not 
        /// valid you cant leave the text box unless its been emptyed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLeave(object sender, EventArgs e)
        {
            var theControlBeingLeft = (Control)sender;

            if (string.IsNullOrEmpty(theControlBeingLeft.Text))
            {
                carErrorProvider.SetError(theControlBeingLeft, string.Empty);
            }
        }

        /// <summary>
        /// If the feilds Make and Model are left empty when adding to list error providers will show 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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

        /// <summary>
        /// validates the criteria for Year
        /// </summary>
        /// <param name="input"></param>
        /// <param name="errorProvider"></param>
        /// <returns></returns>
        private static bool ValidateYear(Control input, ErrorProvider errorProvider)
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

        /// <summary>
        /// If the year is valid and not empty you can leave the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateYear(object sender, CancelEventArgs e)
        {
            if (Year.Text != string.Empty && ValidateYear(Year, carErrorProvider) == false)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Validates the year search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateSearchingYear(object sender, CancelEventArgs e)
        {
            var input = (Control)sender;
            if (Year.Text != string.Empty && ValidateYear(input, searchErrorProvider) == false)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateSearchingPrice(object sender, CancelEventArgs e)
        {
            var input = (Control)sender;
            if (Year.Text != string.Empty && ValidatePrice(input, searchErrorProvider) == false)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Validates the searching price range criteria and displays error provideors
        /// </summary>
        /// <returns></returns>
        private bool ValidateSearchPriceRange()
        {
            if (SearchPriceFrom.Text == string.Empty || SearchPriceTo.Text == string.Empty)
            {
                return true;
            }

            var from = decimal.Parse(SearchPriceFrom.Text);
            var to = decimal.Parse(SearchPriceTo.Text);

            if (from >= to)
            {
                const string error = "'to' cannot be less than or equal to 'from'";
                searchErrorProvider.SetError(SearchPriceFrom, error);
                searchErrorProvider.SetError(SearchPriceTo, error);
                return false;
            }

            searchErrorProvider.SetError(SearchPriceFrom, string.Empty);
            searchErrorProvider.SetError(SearchPriceTo, string.Empty);
            return true;
        }

        /// <summary>
        /// Validates Price for criteria and displays error providers 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="errorProvider"></param>
        /// <returns></returns>
        private static bool ValidatePrice(Control input, ErrorProvider errorProvider)
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

        /// <summary>
        /// if the price textBox is empty or valid it will let you leave the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidatePrice(object sender, CancelEventArgs e)
        {
            if (Price.Text != string.Empty && ValidatePrice(Price, carErrorProvider) == false)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// validates all the cars text boxes
        /// </summary>
        /// <returns></returns>
        private bool ValidateCar()
        {
            return ValidateYear(Year, carErrorProvider) &
                ValidatePrice(Price, carErrorProvider) &
                ValidateNotEmpty(Make) &
                ValidateNotEmpty(Model);
        }

        /// <summary>
        /// Saves the file on click if there is items to save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SaveFile_Click(object sender, EventArgs e)
        {
            var cars = CarList.Items.OfType<Car>();

            if (!cars.Any())
            {
                MessageBox.Show("No cars to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        /// <summary>
        /// Loads the txt file onto the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void LoadFile_Click(object sender, EventArgs e)
        {
            CarList.Items.Clear();

            foreach (var car in await FileManager.Load())
            {
                CarList.Items.Add(car);
            }

            ShowSaleStatistics();
        }

        /// <summary>
        /// allows the seaching text boxes to be searched for using the
        /// cars loaded onto the list box and validates the text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                    if (canSearch && ValidateSearchPriceRange())
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

        /// <summary>
        /// If there are no search results that meet the criteria it will show no search
        /// results found otherwise load the filtered cars onto the CarList list box
        /// </summary>
        /// <param name="filteredCars"></param>
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

        /// <summary>
        /// makes search panels visible depending on whats selected
        /// </summary>
        private void ConfigureSearchForm()
        {
            var by = ((SearchOption)SearchBy.SelectedItem).By;

            SearchByYearPanel.Visible = by == SearchType.Year;
            MakeAndPriceRangePanel.Visible = by == SearchType.MakeAndPriceRange;
        }

        /// <summary>
        /// When you change from make and price search or year it will make the corisponding panel visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigureSearchForm();
        }
    }
}
