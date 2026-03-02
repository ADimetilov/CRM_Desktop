using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для Service.xaml
    /// </summary>
    public partial class Service : Page
    {
        public Service()
        {
            InitializeComponent();
            get_api_service();
        }
        public async Task get_api_service()
        {
            await API.get_all_service_resp(Service_resp_list);
            await API.get_all_service_cust(ListBoxCust);
            await API.get_all_service_free(ServiceFreeList);
            await API.get_all_service(ListServiceAll);
        }
    }
}
