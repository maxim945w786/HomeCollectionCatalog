using System.Windows;

namespace HomeCollectionCatalog
{
    public partial class RegistrationPage : Window
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (PasswordBox.Password !=
                ConfirmPasswordBox.Password)
            {
                MessageBox.Show(
                    "Пароли не совпадают",
                    "Ошибка регистрации",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );

                return;
            }

            MessageBox.Show(
                "Регистрация в разработке",
                "Информация",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }
    }
}