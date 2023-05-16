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
            // TODO: validation 

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

            AverageCarSalesIncludingGst.Text = CarSales.GetAverageCarSalePriceIncludingGst(cars).ToString();
            AverageCarSalesExcludingGst.Text = CarSales.GetAverageCarSalePriceExcludingGst(cars).ToString();
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            CarList.Items.Clear();

            AverageCarSalesIncludingGst.Text = string.Empty;
            AverageCarSalesExcludingGst.Text = string.Empty;
        }

        
    }
}