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
    /// Логика взаимодействия для EditPositionWindow.xaml
    /// </summary>
    public partial class EditPositionWindow : Window
    {
        public EditPositionWindow(Position position)
        {
            InitializeComponent();
            MainViewModel.SelectedPosition = position;
            MainViewModel.PositionName = position.PositionName;
            MainViewModel.PositionSalary = position.Salary;
            MainViewModel.PositionMaxCountOfEmp=position.MaxCountOfEmployees;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
