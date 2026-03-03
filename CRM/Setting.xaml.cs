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

namespace CRM
{
    /// <summary>
    /// Логика взаимодействия для Setting.xaml
    /// </summary>
    public partial class Setting : Window
    {
        public Setting()
        {
            InitializeComponent();
            ip_adress.Text = Properties.Settings.Default.server;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            bool connect = await API.check_heart(ip_adress.Text);
            if (connect)
            {
                Properties.Settings.Default.server = ip_adress.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Настройки успешно применены");
            }
            else
            {
                MessageBox.Show("Проверьте правильность адреса сервера");
            }
        }
    }
}
