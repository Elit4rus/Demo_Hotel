using Demo_Hotel.AppData;
using Demo_Hotel.Model;
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

namespace Demo_Hotel.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        const int USER_ROLE_ID = 2;
        // 2-ой вариант именования: userRoleID
        public UsersPage()
        {
            InitializeComponent();

            // Загрузка пользователей в список
            UsersLv.ItemsSource = App.context.User.Where(u => u.RoleId == USER_ROLE_ID).ToList();
        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UsersLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserDetailsGrid.DataContext = UsersLv.SelectedItem as User;
        }

        private void SaveChangesBtn_Click(object sender, RoutedEventArgs e)
        {
            App.context.SaveChanges();

            Feedback.Information("Информация успешно изменена!");
        }
    }
}
