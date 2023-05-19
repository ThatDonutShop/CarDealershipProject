using CarDealership.Core;

namespace CarDealershipAssesment2
{
    public partial class CarListForm : Form
    {
        public CarListForm()
        {
            InitializeComponent();
        }

        private void CarListForm_Load(object sender, EventArgs e)
        {
            ActiveControl = Make;
        }

        private void ClearInputs()
        {
            Make.Text = string.Empty;
            Model.Text = string.Empty;
            Year.Text = string.Empty;
            Price.Text = string.Empty;

            Make.Focus();
        }
        private void AddToList_Click_1(object sender, EventArgs e)
        {

            var year = int.Parse(Year.Text);
            var price = decimal.Parse(Price.Text);
            var car = Car.Create(Make.Text, Model.Text, year, price);

            CarList.Items.Add(car);

            ShowSaleStatistics();

            ClearInputs();
        }

        private void ShowSaleStatistics()
        {
            var cars = CarList.Items.OfType<Car>();
            //TODO: money format
            AverageCarSalesIncludingGst.Text = CarSales.GetAverageCarSalePriceIncludingGst(cars).ToString("C");
            AverageCarSalesExcludingGst.Text = CarSales.GetAverageCarSalePriceExcludingGst(cars).ToString("C");
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            CarList.Items.Clear();

            AverageCarSalesIncludingGst.Text = string.Empty;
            AverageCarSalesExcludingGst.Text = string.Empty;
        }

        private void MakeValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Make.Text))
            {
                e.Cancel = true;
                Make.Focus();
                errorProviderIsNull.SetError(Make, "You must enter a cars make. It cant be left empty");
            }
            else
            {
                e.Cancel = false;
                //errorProviderIsNull.SetError(Make, "");
            }
        }

        private void ModelValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Model.Text))
            {
                e.Cancel = true;
                Model.Focus();
                errorProviderIsNull.SetError(Model, "You must enter a cars Model. It cant be left empty");
            }
            else
            {
                e.Cancel = false;
                errorProviderIsNull.SetError(Model, "");
            }
        }

        private void YearValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Year.Text))
            {
                e.Cancel = true;
                Year.Focus();
                errorProviderIsNull.SetError(Year, "You must enter a cars Year. It cant be left empty");
            }
            else
            {
                e.Cancel = false;
                errorProviderIsNull.SetError(Year, "");
            }
            if (!decimal.TryParse(Year.Text, out decimal result))
            {
                e.Cancel = true;
                Year.Focus();
                errorProviderNotInt.SetError(Year, "You must enter a cars Year. It cant be text only numbers are accepted");
            }
            else
            {
                e.Cancel = false;
                errorProviderNotInt.SetError(Year, "");
            }
        }
    }
}