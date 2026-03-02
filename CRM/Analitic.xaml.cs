using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    }
}
