using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.Serialization.Json;
using System.Windows.Controls;
using System.Net.Http.Json;
using System.Security.AccessControl;
namespace CRM
{
    public static class API
    {

        public static async Task<bool> check_heart(string server)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string reply = await client.GetStringAsync($"http://{server}/status");
                    if (reply == "true")
                    {
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не получилось соединиться с сервером");
                return false;
            }
        }

        public static async Task get_all_organization(ComboBox OrganizationBox)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string reply = await client.GetStringAsync($"http://{Properties.Settings.Default.server}/organization/all");
                    byte[] JsonBytes = Encoding.UTF8.GetBytes(reply);
                    MemoryStream stream = new MemoryStream(JsonBytes);
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Organization>));
                        List<Organization> OrganizationList = (List<Organization>)jsonSerializer.ReadObject(stream);
                        OrganizationBox.ItemsSource = OrganizationList;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не получилось соединиться с сервером");
            }
        }
        public static async Task get_all_service(ComboBox ServiceBox)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string reply = await client.GetStringAsync($"http://{Properties.Settings.Default.server}/service/all");
                    byte[] JsonBytes = Encoding.UTF8.GetBytes(reply);
                    MemoryStream stream = new MemoryStream(JsonBytes);
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Service_>));
                        List<Service_> ServiceList = (List<Service_>)jsonSerializer.ReadObject(stream);
                        ServiceBox.ItemsSource = ServiceList;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не получилось соединиться с сервером");
            }
        }
        public static async Task get_all_service(ListBox listBox)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string reply = await client.GetStringAsync($"http://{Properties.Settings.Default.server}/service/all/list");
                    byte[] JsonBytes = Encoding.UTF8.GetBytes(reply);
                    MemoryStream stream = new MemoryStream(JsonBytes);
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Service_list>));
                        List<Service_list> ServiceList = (List<Service_list>)jsonSerializer.ReadObject(stream);
                        listBox.ItemsSource = ServiceList;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не получилось соединиться с сервером");
            }
        }
        public static async Task get_all_status(ComboBox StatusBox)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string reply = await client.GetStringAsync($"http://{Properties.Settings.Default.server}/status/all");
                    byte[] JsonBytes = Encoding.UTF8.GetBytes(reply);
                    MemoryStream stream = new MemoryStream(JsonBytes);
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Status>));
                        List<Status> Status_list = (List<Status>)jsonSerializer.ReadObject(stream);
                        StatusBox.ItemsSource = Status_list;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не получилось соединиться с сервером");
            }
        }
        public static async Task get_all_user(ComboBox UserBox)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string reply = await client.GetStringAsync($"http://{Properties.Settings.Default.server}/user/all");
                    byte[] JsonBytes = Encoding.UTF8.GetBytes(reply);
                    MemoryStream stream = new MemoryStream(JsonBytes);
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<User>));
                        List<User> User_list = (List<User>)jsonSerializer.ReadObject(stream);
                        UserBox.ItemsSource = User_list;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не получилось соединиться с сервером");
            }
        }
        public static async Task get_all_service_resp(ListBox ServiceRespBox)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string reply = await client.GetStringAsync($"http://{Properties.Settings.Default.server}/service/all/user_resp?id={User_Info.id}");
                    byte[] JsonBytes = Encoding.UTF8.GetBytes(reply);
                    MemoryStream stream = new MemoryStream(JsonBytes);
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Service_resp>));
                        List<Service_resp> Service_resp_list = (List<Service_resp>)jsonSerializer.ReadObject(stream);
                        ServiceRespBox.ItemsSource = Service_resp_list;
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }

        public static async Task get_all_service_cust(ListBox ServiceRespBox)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string reply = await client.GetStringAsync($"http://{Properties.Settings.Default.server}/service/all/user_cust?id={User_Info.id}");
                    byte[] JsonBytes = Encoding.UTF8.GetBytes(reply);
                    MemoryStream stream = new MemoryStream(JsonBytes);
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Service_cust>));
                        List<Service_cust> Service_cust_list = (List<Service_cust>)jsonSerializer.ReadObject(stream);
                        ServiceRespBox.ItemsSource = Service_cust_list;
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }

        public static async Task get_all_service_free(ListBox ServiceFreeBox)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string reply = await client.GetStringAsync($"http://{Properties.Settings.Default.server}/service/all/free?id={User_Info.id}");
                    byte[] JsonBytes = Encoding.UTF8.GetBytes(reply);
                    MemoryStream stream = new MemoryStream(JsonBytes);
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Service_free>));
                        List<Service_free> Service_free_list = (List<Service_free>)jsonSerializer.ReadObject(stream);
                        ServiceFreeBox.ItemsSource = Service_free_list;
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }

        public static async Task<Boolean> auth_user(UserAuth userAuth)
        {
            try
            {
                JsonContent content = JsonContent.Create(userAuth);
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.PostAsync($"http://{Properties.Settings.Default.server}/user/auth", content);
                     if (response.IsSuccessStatusCode)
                     {
                            string responseBody = await response.Content.ReadAsStringAsync();
                            if (responseBody == "true")
                            {
                                return true;
                            }
                     }
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не получилось соединиться с сервером");
                return false;
            }
        }
        public static async Task get_info_for_user(string login)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string reply = await client.GetStringAsync($"http://{Properties.Settings.Default.server}/user/info?login={login}");
                    byte[] JsonBytes = Encoding.UTF8.GetBytes(reply);
                    MemoryStream stream = new MemoryStream(JsonBytes);
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(UserInfo_API));
                        UserInfo_API userInfo_ = (UserInfo_API)jsonSerializer.ReadObject(stream);
                        User_Info.id = userInfo_.id;
                        User_Info.name = userInfo_.name;
                        User_Info.role = userInfo_.role;
                        User_Info.id_suborg = userInfo_.id_suborg;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не получилось соединиться с сервером");
            }
        }

        public static async Task<Organization_current> get_info_suborganization()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string reply = await client.GetStringAsync($"http://{Properties.Settings.Default.server}/organization?id={User_Info.id_suborg}");
                    byte[] JsonBytes = Encoding.UTF8.GetBytes(reply);
                    MemoryStream stream = new MemoryStream(JsonBytes);
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Organization_current));
                        Organization_current organization_ = (Organization_current)jsonSerializer.ReadObject(stream);
                        return organization_;
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Произошла ошибка:" + Error.ToString());
                return null;
            }
        }

        public static async Task get_info_service_sub(ListBox ServiceListOrgan)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string reply = await client.GetStringAsync($"http://{Properties.Settings.Default.server}/organization/service?id={User_Info.id_suborg}");
                    byte[] JsonBytes = Encoding.UTF8.GetBytes(reply);
                    MemoryStream stream = new MemoryStream(JsonBytes);
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Organization_service>));
                        List<Organization_service> services = (List<Organization_service>)jsonSerializer.ReadObject(stream);
                        ServiceListOrgan.ItemsSource = services;
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Произошла ошибка:" + Error.ToString());
            }
        }

        public static async Task get_info_users_sub(DataGrid UserListOrgan)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string reply = await client.GetStringAsync($"http://{Properties.Settings.Default.server}/organization/users?id={User_Info.id_suborg}");
                    byte[] JsonBytes = Encoding.UTF8.GetBytes(reply);
                    MemoryStream stream = new MemoryStream(JsonBytes);
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Organization_users>));
                        List<Organization_users> users = (List<Organization_users>)jsonSerializer.ReadObject(stream);
                        UserListOrgan.ItemsSource = users;
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Произошла ошибка:" + Error.ToString());
            }
        }


        public static async Task<int> get_analitics_count(Analitic_config analitic_config)
        {
            try
            {
                JsonContent content = JsonContent.Create(analitic_config);
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.PostAsync($"http://{Properties.Settings.Default.server}/analitic/get/count", content);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        return Convert.ToInt32(responseBody);
                    }
                    return 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не получилось соединиться с сервером");
                return 0;
            }
        }

        public static async Task get_analitics_list(Analitic_config analitic_config,DataGrid AnaliticDataGrid)
        {
            try
            {
                JsonContent content = JsonContent.Create(analitic_config);
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.PostAsync($"http://{Properties.Settings.Default.server}/analitic/get/list", content);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        byte[] JsonBytes = Encoding.UTF8.GetBytes(responseBody);
                        MemoryStream stream = new MemoryStream(JsonBytes);
                        {
                            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Services>));
                            List<Services> services = (List<Services>)jsonSerializer.ReadObject(stream);
                            AnaliticDataGrid.ItemsSource = services;
                        }
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }
    }
}
