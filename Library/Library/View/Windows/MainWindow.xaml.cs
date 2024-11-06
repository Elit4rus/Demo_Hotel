using Library.Model;
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

namespace Library
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> books = App.context.Book.ToList();
        List<Genre> genres = App.context.Genre.ToList();
        public MainWindow()
        {
            InitializeComponent();
            LibraryLv.ItemsSource = books;
            GenreCmb.ItemsSource = genres;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Book newBook = new Book()
                {
                    Title = NameBookTb.Text,
                    DateOfReceipt = (DateTime)DateOfReceiptDp.SelectedDate,
                    GenreID = GenreCmb.SelectedIndex + 1,
                    Author = NameAuthorBookTb.Text,
                    YearOfPublication = Convert.ToInt32(YearBookTb.Text),
                    IsRequiredForTraining = (bool)MandatoryOrListenCb.IsChecked
                };
                App.context.Book.Add(newBook);
                App.context.SaveChanges();
                MessageBox.Show("Книга успешно добавлена!");
                Clear();
                LibraryLv.ItemsSource = App.context.Book.ToList();
                
            }
            catch
            {
                MessageBox.Show("Данные введены неверное!");
            }
        }
        private void Clear()
        {
            NameBookTb.Text = "";
            DateOfReceiptDp.Text = "";
            GenreCmb.Text = "";
            NameAuthorBookTb.Text = "";
            YearBookTb.Text = "";
            MandatoryOrListenCb.IsChecked = false;
        }
    }
}
