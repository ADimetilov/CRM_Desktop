using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
            InitAdministrator();
        }

        public void initButton()
        {
            String role = "Администратор";
            if (role == "Администратор")
            {

            } 
        }
        public void InitAdministrator()
        {
            Button administratorr = new Button();
            administratorr.Content = "Настройка ИС";
            administratorr.Click += Administratorr_Click;
            buttonsBox.Items.Add(administratorr);
            InitOwner();
        }

        private void Administratorr_Click(object sender, RoutedEventArgs e)
        {
        }

        public void InitAnalitik()
        {
            Button analitic = new Button();
            analitic.Content = "Аналитика";
            analitic.Click += Analitic_Click;
            buttonsBox.Items.Add(analitic);
            InitUser();
        }

        private void Analitic_Click(object sender, RoutedEventArgs e)
        {
            pageFrame.Content = new Analitic();
        }

        public void InitOwner()
        {
            Button suborg = new Button();
            suborg.Content = "Подразделение";
            suborg.Click += Suborg_Click;
            buttonsBox.Items.Add(suborg);
            Button edituser = new Button();
            edituser.Content = "Управление пользователями";
            edituser.Click += Suborg_Click;
            InitAnalitik();
        }

        private void Suborg_Click(object sender, RoutedEventArgs e)
        {
            pageFrame.Content = new SubOrganization();
        }

        public void InitUser()
        {
            Button button = new Button();
            button.Content = "Заявки";
            button.Click += Button_Click;
            buttonsBox.Items.Add(button);
            Button button_user = new Button();
            button_user.Content = "Пользователь";
            button_user.Click += Button_user_Click;
            buttonsBox.Items.Add(button_user);
        }

        private void Button_user_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (buttonsBox.SelectedIndex != -1)
            {
                Button button = (Button)buttonsBox.SelectedItem;
                button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
        }
    }
}
