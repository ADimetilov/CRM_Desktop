using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace CRM
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            UserAuth userAuth = new UserAuth();
            userAuth.login = uLogin.Text;
            userAuth.password = uPassword.Password;
            if (await API.auth_user(userAuth) == true)
            {
                await API.get_info_for_user(userAuth.login);
                UserWindow userWindow = new UserWindow();
                this.Visibility = Visibility.Hidden;
                userWindow.ShowDialog();
                this.Visibility = Visibility.Visible;
            }
            else MessageBox.Show("Введен неверный логин или пароль");
            
        }
    }
}
