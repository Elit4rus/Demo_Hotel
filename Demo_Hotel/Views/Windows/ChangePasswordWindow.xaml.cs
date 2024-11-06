using Demo_Hotel.AppData;
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
using System.Windows.Shapes;

namespace Demo_Hotel.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для ChangePasswordWindow.xaml
    /// </summary>
    public partial class ChangePasswordWindow : Window
    {
        public ChangePasswordWindow()
        {
            InitializeComponent();
        }

        private void ChangePasswordBtn_Click(object sender, RoutedEventArgs e)
        {

        }
        void ChangePassword()
        {
            if (string.IsNullOrEmpty(OldPasswordPb.Password) ||
                string.IsNullOrEmpty(NewPasswordPb.Password) ||
                string.IsNullOrEmpty(AcceptNewPasswordPb.Password))
            {
                Feedback.Warning("Все поля обязательны для заполнения! Заполните каждое поле!");
            }
        }
    }
}
