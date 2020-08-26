using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWork12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Repository data;
        public MainWindow()
        {
            InitializeComponent();

            data = Repository.CreateRepository();

            cbDepartment.ItemsSource = data.DepartmentDb;

        }

        private void cbDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lvEmployee.ItemsSource = data.EmployeeDb.Where(find);
        }

        private bool find(Employee arg)
        {
            return arg.DepartmentId == (cbDepartment.SelectedItem as Department).DepartmentId;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cbDepartment.Items.Refresh(); 

        }
    }
}
