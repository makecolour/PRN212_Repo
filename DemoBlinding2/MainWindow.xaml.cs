using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace DemoBlinding2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        List<Car> list = new List<Car>() { new Car { Id = 1, Name = "City", Color = "Red", Brand = "Honda" },
                                           new Car { Id = 2, Name = "Civic", Color = "Black", Brand = "Honda" }
                                         };

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string name = txtName.Text;
            string color = txtColor.Text;
            string brand = txtBrand.Text;

            var x = list.FirstOrDefault(x => x.Id == id);
            if (x != null) return;
            list.Add(new Car { Id = id, Name = name, Color = color, Brand = brand });
            dgvDisplay.Items.Refresh();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgvDisplay.ItemsSource = list;
        }

        private void dgvDisplay_SelectedCellsChanged(object sender, System.Windows.Controls.SelectedCellsChangedEventArgs e)
        {
            if (dgvDisplay.SelectedItem != null)
            {
                txtId.Text = ((Car)dgvDisplay.SelectedItem).Id.ToString();
                txtName.Text = ((Car)dgvDisplay.SelectedItem).Name.ToString();
                txtColor.Text = ((Car)dgvDisplay.SelectedItem).Color.ToString();
                txtBrand.Text = ((Car)dgvDisplay.SelectedItem).Brand.ToString();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string name = txtName.Text;
            string color = txtColor.Text;
            string brand = txtBrand.Text;

            var x = list.FirstOrDefault(x => x.Id == id);
            if (x == null) { return; }
            x.Name = name;
            x.Color = color;
            x.Brand = brand;
            dgvDisplay.ItemsSource = list;
            dgvDisplay.Items.Refresh();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Alert", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
            {
                int id = int.Parse(txtId.Text);
                var x = list.FirstOrDefault(x => x.Id == id);
                if (x != null)
                {
                    list.Remove(x);
                    dgvDisplay.ItemsSource = list;
                    dgvDisplay.Items.Refresh();
                }
            }
        } 
        }
}