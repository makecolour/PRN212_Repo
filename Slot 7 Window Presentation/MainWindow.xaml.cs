using Microsoft.EntityFrameworkCore;
using Slot_7_Window_Presentation.Models;
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

namespace Slot_7_Window_Presentation
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
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            Load();
            
        }

        private void Load()
        {
            //var context = new Prn211Context();
            //var list = context.Students.Include(x => x.Depart).Select(x => new { Id = x.Id, Name = x.Name, Gender = x.Gender ? "Male" : "Female", DepartId = x.DepartId, Depart = x.Depart, Dob = x.Dob, Gpa = x.Gpa }).ToList();
            //Singleton Pattern
            var list = Prn211Context.INSTANCE.Students.Include(x => x.Depart).ToList();
            dgvDisplay.ItemsSource = list;
            cbDepart.ItemsSource = Prn211Context.INSTANCE.Departments.Select(x => x.Name).ToList();
            DepartmentSearch.ItemsSource = Prn211Context.INSTANCE.Departments.Select(x => x.Name).ToList();
            dgvDisplay.Items.Refresh();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbDepart.ItemsSource = Prn211Context.INSTANCE.Departments.Select(x => x.Name).ToList();
            DepartmentSearch.ItemsSource = Prn211Context.INSTANCE.Departments.Select(x => x.Name).ToList();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            Student st = GetStudent();
            if (st == null) { return; }
            var x = Prn211Context.INSTANCE.Students.Find(st.Id);
            if (x != null) { return; }
            Prn211Context.INSTANCE.Students.Add(st);
            Prn211Context.INSTANCE.SaveChanges();
            Load();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Student st = GetStudent();
            if (st == null) { return; }
            var x = Prn211Context.INSTANCE.Students.Find(st.Id);
            if (x == null) { return; }
            x.Name = st.Name;
            x.Gpa = st.Gpa;
            x.Dob = st.Dob;
            x.DepartId = st.DepartId;
            x.Gender = st.Gender;
            Prn211Context.INSTANCE.Students.Update(x);
            Prn211Context.INSTANCE.SaveChanges();
            Load();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var x = Prn211Context.INSTANCE.Students.Find(id);
            if (x == null) { return; }
            Prn211Context.INSTANCE.Students.Remove(x);
            Prn211Context.INSTANCE.SaveChanges();
            Load();
        }

        private Student GetStudent()
        {
            Student st = new Student();
            try
            {
                st.Id = int.Parse(txtId.Text);
                st.Name = txtName.Text;
                st.Gender = rbMale.IsChecked == true;
                st.Dob = (DateOnly.FromDateTime(dpDob.SelectedDate.Value));
                st.Gpa = double.Parse(txtGPA.Text);
                st.DepartId = Prn211Context.INSTANCE.Departments.
                    FirstOrDefault(x => x.Name.Equals(cbDepart.SelectedValue.ToString())).Id;
                return st;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        private void DepartmentSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string department = DepartmentSearch.SelectedValue.ToString();
            var list = Prn211Context.INSTANCE.Students.Include(x => x.Depart).Where(x => x.Depart.Name.Contains(department)).ToList();
            dgvDisplay.ItemsSource = list;
            dgvDisplay.Items.Refresh();
        }

        private void Gender_Checked(object sender, RoutedEventArgs e)
        {
            var gender = (((RadioButton)sender).Content.ToString() == "Male");

                var list = Prn211Context.INSTANCE.Students.Include(x => x.Depart)
                                           .Where(x => x.Gender == gender)
                                           .ToList();
                dgvDisplay.ItemsSource = list;
                dgvDisplay.Items.Refresh();
        }
    }
}