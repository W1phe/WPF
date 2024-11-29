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

namespace wpfmgok
{
    /// <summary>
    /// Логика взаимодействия для EmployeesAdd.xaml
    /// </summary>
    public partial class EmployeesAdd : Page
    {
        public EmployeesAdd()
        {
            InitializeComponent();
        }

        private void AddEmployee(object sender, RoutedEventArgs e)
        {
            string name = NameBox.Text;
            string surname = PostBox.Text;
            string phoneNumber = PhoneNumberBox.Text;
        }
    }
}