using Barbershop.AppData;
using Barbershop.View.Pages;
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

namespace Barbershop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameHelper.mainFrame = MainFrame;

            // Открытие страницы на окне
            MainFrame.Navigate(new WelcomePage());
        }

        private void ManufacturerBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ManufacturerPage());
        }

        private void ProductBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductPage());
        }

        private void EmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EmployeePage());
        }

        private void AccountingBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AccountingPage());
        }

        private void ReportEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReportDateBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
