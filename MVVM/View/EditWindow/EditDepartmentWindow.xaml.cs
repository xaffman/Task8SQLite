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
using System.Windows.Shapes;
using Task8SQLite.MVVM.VeiwModel;

namespace Task8SQLite.MVVM.View.EditWindow
{
    /// <summary>
    /// Логика взаимодействия для EditDepartmentWindow.xaml
    /// </summary>
    public partial class EditDepartmentWindow : Window
    {
        public EditDepartmentWindow(Department department)
        {
            InitializeComponent();
            MainViewModel.SelectedDepartment = department;
            MainViewModel.DepartmentName = department.DepartmentName;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
