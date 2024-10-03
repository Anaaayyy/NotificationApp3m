using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace NotificationApp
{
    public partial class MainWindow : Window
    {
        private Notification _notification;

        public MainWindow()
        {
            InitializeComponent();
            _notification = new Notification();

            // Регистрация событий
            _notification.OnMessageSent += (message) => ResultTextBlock.Text = $"Сообщение отправлено: {message}";
            _notification.OnCallReceived += (caller) => ResultTextBlock.Text = $"Звонок от: {caller}";
            _notification.OnEmailSent += (email) => ResultTextBlock.Text = $"E-mail отправлен: {email}";
        }

        // Обработчик для отправки сообщения
        private void MessageButton_Click(object sender, RoutedEventArgs e)
        {
            string message = InputTextBox.Text;
            if (!string.IsNullOrEmpty(message))
            {
                _notification.SendMessage(message);
            }
            else
            {
                ResultTextBlock.Text = "Введите сообщение.";
            }
        }

        // Обработчик для принятия звонка
        private void CallButton_Click(object sender, RoutedEventArgs e)
        {
            string caller = InputTextBox.Text;
            if (!string.IsNullOrEmpty(caller))
            {
                _notification.ReceiveCall(caller);
            }
            else
            {
                ResultTextBlock.Text = "Введите имя звонящего.";
            }
        }

        // Обработчик для отправки e-mail
        private void EmailButton_Click(object sender, RoutedEventArgs e)
        {
            string email = InputTextBox.Text;
            if (!string.IsNullOrEmpty(email))
            {
                _notification.SendEmail(email);
            }
            else
            {
                ResultTextBlock.Text = "Введите e-mail.";
            }
        }
    }
}
