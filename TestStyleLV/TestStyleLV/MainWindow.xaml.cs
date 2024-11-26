using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace TestStyleLV
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> People { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            People = new ObservableCollection<Person>
            {
                new Person {Fullname = "Иван Иванов", PhoneNumber = "+7123456789"},
                new Person {Fullname = "Петр Петров", PhoneNumber = "+7987654321"},
                new Person {Fullname = "Алексей Алексеевич", PhoneNumber = "+7555555555"}
            };

            DataContext = this;
        }
        public class Person
        {
            public string Fullname { get; set; }
            public string PhoneNumber { get; set; }
        }
    }
}
