using Demo_Hotel.AppData;
using Demo_Hotel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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

namespace Demo_Hotel.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public AddUserWindow()
        {
            InitializeComponent();
        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {
            AddUser();
        }

        public void AddUser()
        {
            try
            {
                if (string.IsNullOrEmpty(FullNameTb.Text) ||
                    string.IsNullOrEmpty(LoginTb.Text) ||
                    string.IsNullOrEmpty(PasswordPb.Password))
                {
                    Feedback.Warning("Все поля обязательны для заполнения! Заполните каждое поле");
                }
                else
                {
                    User newUser = new User()
                    {
                        Fullname = FullNameTb.Text,
                        Login = LoginTb.Text,
                        Password = PasswordPb.Password,
                        RegistrationDate = DateTime.Now.Date,
                        IsActivated = false,
                        IsBlocked = false,
                        RoleId = 2
                    };
                    App.context.User.Add(newUser);
                    App.context.SaveChanges();
                    Feedback.Information("Пользователь успешно добавлен!");
                    DialogResult = true;
                }
            }
            catch (DbUpdateException dbUpdateException)
            {
                Feedback.Error($"Пользователь с таким логином уже существует. Придумайте новый. {dbUpdateException.Message}");
            }
            catch (Exception exception)
            {
                Feedback.Error($"Ошибка при добавлении пользователя. {exception.Message}");
            }
        }
    }
}
