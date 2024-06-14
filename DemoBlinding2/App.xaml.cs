using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Xml.Linq;

namespace DemoBinding2
{
    public partial class App : Application
    {
        List<Car> list = new List<Car>();

        public App()
        {
            InitializeComponent();
            // Initialize the list with some sample cars
            list.Add(new Car { Id = 1, Name = "City", Color = "Red", Brand = "Honda" });
            list.Add(new Car { Id = 2, Name = "Civic", Color = "Black", Brand = "Honda" });
            // Set the data context for the window
            this.DataContext = this;
        }

        public List<Car> Cars
        {
            get { return list; }
            set { list = value; }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            // Input validation
            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }
            // Check if the car with the same ID already exists
            if (list.Any(x => x.Id == id))
            {
                MessageBox.Show("A car with the same ID already exists.");
                return;
            }
            // Create a new car and add it to the list
            string name = txtName.Text;
            string color = txtColor.Text;
            string brand = txtBrand.Text;
            list.Add(new Car { Id = id, Name = name, Color = color, Brand = brand });
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Input validation
            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }
            // Find the car with the specified ID
            Car car = list.FirstOrDefault(x => x.Id == id);
            if (car == null)
            {
                MessageBox.Show("Car not found.");
                return;
            }
            // Update the car details
            car.Name = txtName.Text;
            car.Color = txtColor.Text;
            car.Brand = txtBrand.Text;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            // Input validation
            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }
            // Find the car with the specified ID
            Car car = list.FirstOrDefault(x => x.Id == id);
            if (car == null)
            {
                MessageBox.Show("Car not found.");
                return;
            }
            // Confirm deletion
            if (MessageBox.Show("Are you sure you want to delete this car?", "Confirm Delete", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                // Remove the car from the list
                list.Remove(car);
            }
        }
    }

    // Define the Car class
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
    }
}