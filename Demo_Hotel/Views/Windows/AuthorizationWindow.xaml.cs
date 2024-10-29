using Demo_Hotel.AppData;
using System.Linq;
using System.Windows;

namespace Demo_Hotel.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Validation() == true)
            {
                Authentication();
            }
        }

        public bool Validation()
        {
            if (string.IsNullOrEmpty(LoginTb.Text) && string.IsNullOrEmpty(PasswordPb.Password))
            {
                Feedback.Warning("Поля для ввода не должны быть пустым. Введите логин и пароль!");
                return false;
            }
            else if (string.IsNullOrEmpty(LoginTb.Text))
            {
                Feedback.Warning("Поля для ввода не должны быть пустым. Введите логин!");
                return false;
            }
            else if (string.IsNullOrEmpty(PasswordPb.Password))
            {
                Feedback.Warning("Поля для ввода не должны быть пустым. Введите пароль!");
                return false;
            }
            return true;
        }

        public void Authentication()
        {
            App.currentUser = App.context.User.FirstOrDefault(user => user.Login == LoginTb.Text && user.Password == PasswordPb.Password);

            if (App.currentUser == null)
            {
                Feedback.Error($"Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные!");
            }
            // Иначе если
            else if (App.currentUser.IsBlocked == true)
            {
                Feedback.Error($"Вы заблокированы. Обратитесь к администратору!");
            }
            else if (App.currentUser.IsActivated == false)
            {
                ChangePasswordWindow changePasswordWindow = new ChangePasswordWindow();
                changePasswordWindow.ShowDialog();
            }
            else
            {
                Feedback.Information("Вы успешно авторизовались!");
                Authorization();
                Close();
            }

        }
        public void Authorization()
        {

        }
    }
}
