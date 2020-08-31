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
            RefreshLV();
        }

        /// <summary>
        /// Обновление ListView
        /// </summary>
        private void RefreshLV()
        {
            lvEmployee.ItemsSource = data.EmployeeDb.Where(find);
        }

        private bool find(Employee arg)
        {
            return arg.DepartmentId == (cbDepartment.SelectedItem as Department).DepartmentId;
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            cbDepartment.Items.Refresh(); 
        }

        /// <summary>
        /// Удаляем выделенного сотрудника в ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelEmp_Click(object sender, RoutedEventArgs e)
        {
            int index = data.EmployeeDb.IndexOf(lvEmployee.SelectedItem as Employee);
            data.EmployeeDb.RemoveAt(index);
            RefreshLV();
        }

        /// <summary>
        /// Сортируем сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            AgeComparer ac = new AgeComparer();
            data.EmployeeDb.Sort(ac);
            RefreshLV();
        }

        private void btnSortName_Click(object sender, RoutedEventArgs e)
        {
            data.EmployeeDb.Sort();
            RefreshLV();
        }
    }
}

// Применить полученные знания в домашней работе предыдущего модуля
// * Реализовать UI 
// Добавить возможность 
// - изменения 
// - удаления
// - редактирования
// - * сортировки
// экземпляров Worker и Department
