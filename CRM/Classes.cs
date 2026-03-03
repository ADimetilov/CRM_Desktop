using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class UserAuth
    {
        public string login { get; set; }
        public string password { get; set; }
    }
    [DataContract]
    public class UserInfo_API
    {
        [DataMember(Name ="id")]
        public  int id { get; set; }
        [DataMember(Name = "fio")]
        public string name { get; set; }
        [DataMember(Name = "role")]
        public string role { get; set; }
        [DataMember(Name = "id_suborg")]
        public int id_suborg { get; set; }
    }

    public static class User_Info
    {
        public static int id { get; set; }
        public static string name { get; set; }
        public static string role { get; set; }
        public static int id_suborg { get; set; }
    }
    [DataContract]
    public class Organization_current
    {
        [DataMember(Name = "id")]
        public int id { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "info")]
        public string info { get; set; }
        [DataMember(Name = "value")]
        public int value { get; set; }
    }
    [DataContract]
    public class Organization_service
    {
        [DataMember(Name = "id")]
        public int id { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "format")]
        public string format { get; set; }
        [DataMember(Name = "term")]
        public string term { get; set; }
    }
    [DataContract]
    public class Organization_users
    {
        [DataMember(Name = "id")]
        public int id { get; set; }
        [DataMember(Name = "fio")]
        public string name { get; set; }
        [DataMember(Name = "role")]
        public string role { get; set; }
        [DataMember(Name = "date_registr")]
        public string date_registr { get; set; }
        [DataMember(Name = "mail")]
        public string mail { get; set; }
        [DataMember(Name = "phone")]
        public string phone { get; set; }
    }

    [DataContract]
    public class Organization
    {
        [DataMember(Name ="id")]
        public int id { get; set; }
        [DataMember(Name ="name")]
        public string name { get; set; }
        [DataMember(Name ="info")]
        public string info { get; set; }
    }
    [DataContract]
    public class Service_
    {
        [DataMember(Name = "id")]
        public int id { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "id_suborg")]
        public int id_suborg { get; set; }
    }

    [DataContract]
    public class Service_list
    {
        [DataMember(Name = "id")]
        public int id { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "suborg")]
        public string suborg { get; set; }
    }

    [DataContract]
    public class Status
    {
        [DataMember(Name = "id")]
        public int id { get; set; }
        [DataMember(Name = "status")]
        public string status { get; set; }
    }
    [DataContract]
    public class User
    {
        [DataMember(Name = "id")]
        public int id { get; set; }
        [DataMember(Name = "fio")]
        public string fio { get; set; }
    }
    public class Service_resp
    {
        [DataMember(Name = "id")]
        public int id { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "status")]
        public string status { get; set; }
        [DataMember(Name = "date_start")]
        public string date_start { get; set; }
    }

    [DataContract]
    public class Service_cust
    {
        [DataMember(Name = "id")]
        public int id { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "status")]
        public string status { get; set; }
        [DataMember(Name = "date_start")]
        public string date_start { get; set; }
        [DataMember(Name = "resp")]
        public string resp { get; set; }
    }
    [DataContract]
    public class Service_free
    {
        [DataMember(Name = "id")]
        public int id { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "date_start")]
        public string date_start { get; set; }
    }

    public class Field
    {
        public string field { get; set; }
        public int value { get; set; }
    }

    [DataContract]
    public class Fields
    {
        [DataMember(Name = "field")]
        public string field { get; set; }
        [DataMember(Name = "value")]
        public int value { get; set; }
    }
    public class Analitic_config
    {
        public Dictionary<string, object> field { get; set; } = new Dictionary<string, object>();
        public List<String> keys { get; set; } = new List<string>();
    }

    public class Services
    {
        [DataMember(Name = "id")]
        public int id { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "status")]
        public string status { get; set; }
        [DataMember(Name = "resp")]
        public string resp { get; set; }
        [DataMember(Name = "cust")]
        public string cust { get; set; }
        [DataMember(Name = "date_start")]
        public string date_start { get; set; }
        [DataMember(Name = "date_end")]
        public string date_end { get; set; }
        [DataMember(Name = "comment")]
        public string comment{ get; set; }
    }
}
