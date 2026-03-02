using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
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
    public class Service
    {
        [DataMember(Name = "id")]
        public int id { get; set; }
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "id_suborg")]
        public int id_suborg { get; set; }
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

}
