using CarDealership.Core;

namespace CarDealershipAssesment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            // TODO: validation 

            var year = int.Parse(Year.Text);
            var price = decimal.Parse(Price.Text);
            var car = Car.Create(Make.Text, Model.Text, year, price);

            CarList.Items.Add(car);

            ShowSaleStatistics();
            
            ClearInputs();
        }

        private void ClearInputs()
        {
            Make.Text = string.Empty;
            Model.Text = string.Empty;
            Year.Text = string.Empty;
            Price.Text = string.Empty;

            Make.Focus();
        }

        private void ShowSaleStatistics()
        {
            var cars = CarList.Items.OfType<Car>();

            AverageCarSalesIncludingGst.Text = CarSales.GetAverageCarSalePriceIncludingGst(cars).ToString();
        }

        private void ClearCarList_Click(object sender, EventArgs e)
        {
            CarList.Items.Clear();

            AverageCarSalesIncludingGst.Text = string.Empty;
        }

        private void LoadForm(object sender, EventArgs e)
        {
            ActiveControl = Make;
        }
    }
}