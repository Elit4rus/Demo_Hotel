using Pharmacy.Model;
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

namespace Pharmacy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Material> materials = App.context.Material.ToList();
        List<Manufacturer> manufacturers = App.context.Manufacturer.ToList();
        public MainWindow()
        {
            InitializeComponent();
            ManufacturerCmb.ItemsSource = manufacturers;
            ManufacturerCmb.DisplayMemberPath = "Name";
            ManufacturerCmb.SelectedValuePath = "ID";
            MaterialLv.ItemsSource = materials;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Material material = new Material()
                { 
                    Name = NameTb.Text,
                    Price = Convert.ToDecimal(PriceTb.Text),
                    Manufacturer = ManufacturerCmb.SelectedItem as Manufacturer
                };
                App.context.Material.Add(material);
                App.context.SaveChanges();
                MessageBox.Show("Данные успешно добавлены!");
                MaterialLv.ItemsSource = App.context.Material.ToList();
            }
            catch
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }
    }
}
