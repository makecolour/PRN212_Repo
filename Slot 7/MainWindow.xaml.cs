using System.Windows;
using System.Windows.Controls;

namespace demowpf
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = "Hello World!";
            lblDisplay.Width = 200;
            lblDisplay.Content = s;
            MessageBox.Show(s);
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            string gender = (radioMale.IsChecked == true) ? "Male" : "Female";
            string title = ((ComboBoxItem)comboTitle.SelectedItem).Content.ToString();
            string output = $"Name: {name}\nAge: {age}\nGender: {gender}\nTitle: {title}";
            lblDisplay.Content = output;
        }
    }
}
