using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
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
    /// Логика взаимодействия для Analitic.xaml
    /// </summary>
    public partial class Analitic : Page
    {
        public Analitic()
        {
            InitializeComponent();
            get_api_service();
           
        }
        public async Task get_api_service()
        {
            await API.get_all_organization(OrganizationBox);
            await API.get_all_service(ServiceBox);
            await API.get_all_status(StatusBox);
            await API.get_all_user(UserBox);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Analitic_config analitic_config = new Analitic_config();
            if (AllOrganizationCheck.IsChecked == true)
            {
                analitic_config.field.Add("suborg", (object)-1);
                analitic_config.keys.Add("suborg");
            }
            else
            {
                if (OrganizationBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Необходимо проставить галочку \"Все\" в разделе организация или выбрать подразделение;");
                    return;
                }
                else
                {
                    analitic_config.field.Add("suborg", OrganizationBox.SelectedValue);
                    analitic_config.keys.Add("suborg");
                }
            }
            if (AllServiceCheck.IsChecked == false)
            {
                if (ServiceBox.SelectedIndex != -1)
                {
                    analitic_config.field.Add("id_service", ServiceBox.SelectedValue);
                    analitic_config.keys.Add("id_service");
                }
                else
                {
                    MessageBox.Show("Необходимо проставить галочку \"Все\" в разделе услуги или выбрать услугу");
                    return;
                }
            }
            if (AllStatusCheck.IsChecked == false)
            {
                if (StatusBox.SelectedIndex != -1)
                {
                    analitic_config.field.Add("id_status", StatusBox.SelectedValue);
                    analitic_config.keys.Add("id_status");
                }
                else
                {
                    MessageBox.Show("Необходимо проставить галочку \"Все\" в разделе статус или выбрать его");
                    return;
                }
            }
            if (UserBox.SelectedIndex != -1)
            {
                analitic_config.field.Add("id_user_resp", UserBox.SelectedValue);
                analitic_config.keys.Add("id_user_resp");
            }
            if (date_start.SelectedDate.HasValue)
            {
                analitic_config.field.Add("date_start", date_start.SelectedDate.Value.ToString("yyyy-MM-dd"));
                analitic_config.keys.Add("date_start");
            }
            if (date_end.SelectedDate.HasValue)
            {
                analitic_config.field.Add("date_end", date_end.SelectedDate.Value.ToString("yyyy-MM-dd"));
                analitic_config.keys.Add("date_start");
            }
            ListField.Items.Clear();
            int score = await API.get_analitics_count(analitic_config);
            Field field = new Field { field = "Всего", value = score };
            ListField.Items.Add(field);
            await API.get_analitics_list(analitic_config, DataAnaliticGrid);
            await API.get_analitics_count(analitic_config);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AllOrganizationCheck.IsChecked = false;
            AllStatusCheck.IsChecked = false;
            AllStatusCheck.IsChecked = false;
            AllServiceCheck.IsChecked = false;
            OrganizationBox.SelectedIndex = -1;
            StatusBox.SelectedIndex = -1;
            ServiceBox.SelectedIndex = -1;
            UserBox.SelectedIndex = -1;
            date_start.SelectedDate = null;
            date_end.SelectedDate = null;

        }
    }
}
