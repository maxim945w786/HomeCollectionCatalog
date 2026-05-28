using System.Windows;
using System.Windows.Input;

namespace HomeCollectionCatalog
{
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            MessageBox.Show(
                "Вход в систему в разработке",
                "Информация",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }

        private void RegisterLink_MouseLeftButtonDown(
            object sender,
            MouseButtonEventArgs e)
        {
            RegistrationPage page =
                new RegistrationPage();

            page.Show();
            Close();
        }
    }
}