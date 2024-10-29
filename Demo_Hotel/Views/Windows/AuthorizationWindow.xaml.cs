using Demo_Hotel.AppData;
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


            Authorization();
        }
        public void Authorization()
        {

        }
    }
}
