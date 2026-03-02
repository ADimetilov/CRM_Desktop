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

namespace CRM
{
    public static class API
    {
        public static async Task get_all_organization(ComboBox OrganizationBox)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string reply = await client.GetStringAsync($"http://127.0.0.1:4433/organization/all");
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
                    string reply = await client.GetStringAsync($"http://127.0.0.1:4433/service/all");
                    byte[] JsonBytes = Encoding.UTF8.GetBytes(reply);
                    MemoryStream stream = new MemoryStream(JsonBytes);
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Service>));
                        List<Service> ServiceList = (List<Service>)jsonSerializer.ReadObject(stream);
                        ServiceBox.ItemsSource = ServiceList;
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
                    string reply = await client.GetStringAsync($"http://127.0.0.1:4433/status/all");
                    byte[] JsonBytes = Encoding.UTF8.GetBytes(reply);
                    MemoryStream stream = new MemoryStream(JsonBytes);
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Status>));
                        List<Status> Cartridge_classs = (List<Status>)jsonSerializer.ReadObject(stream);
                        StatusBox.ItemsSource = Cartridge_classs;
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
                    string reply = await client.GetStringAsync($"http://127.0.0.1:4433/user/all");
                    byte[] JsonBytes = Encoding.UTF8.GetBytes(reply);
                    MemoryStream stream = new MemoryStream(JsonBytes);
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<User>));
                        List<User> Cartridge_classs = (List<User>)jsonSerializer.ReadObject(stream);
                        UserBox.ItemsSource = Cartridge_classs;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не получилось соединиться с сервером");
            }
        }
    }
}
