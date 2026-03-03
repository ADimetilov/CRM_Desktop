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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CRM
{
    /// <summary>
    /// Логика взаимодействия для SubOrganization.xaml
    /// </summary>
    public partial class SubOrganization : Page
    {
        private Organization_current organization_;
        public SubOrganization()
        {
            InitializeComponent();
            init_service();
            
        }
        public async void init_service()
        {
            organization_= await API.get_info_suborganization();
            await API.get_info_service_sub(ServiceListOrgan);
            await API.get_info_users_sub(UserDataGrid);
            RunOrgan.Text = organization_.name;
            InfoBlock.Text = organization_.info;
            ValueAllUserBlock.Text = organization_.value.ToString();
        }
    }
}
