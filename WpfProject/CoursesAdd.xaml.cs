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
    public partial class CoursesAdd : Page
    {
        public CoursesAdd()
        {
            InitializeComponent();
        }

        private void AddCourses(object sender, RoutedEventArgs e)
        {
            string teacher = TeacherBox.Text;
            string price = PriceBox.Text;
            string status = StatusBox.Text;
        }
    }
}