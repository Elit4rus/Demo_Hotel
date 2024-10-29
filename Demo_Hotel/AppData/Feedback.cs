using System.Windows;

namespace Demo_Hotel.AppData
{
    /// <summary>
    /// Предоставляет методы для создания сообщений обратной связи с пользователем.
    /// </summary>
    public class Feedback
    {
        public static void Error(string text, string title = "Ошибка")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public static void Warning(string text, string title = "Предупреждение")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        public static void Information(string text, string title = "Информация")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
