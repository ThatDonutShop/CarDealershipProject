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
            var year = int.Parse(Year.Text);
            var price = decimal.Parse(Price.Text);
            var car = Car.Create(Make.Text, Model.Text, year, price);
            CarList.Items.Add(car);
        }
    }
}