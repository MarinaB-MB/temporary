using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ITG.Models
{
    public class Company : Companies
    {
        [XmlElement("id")]
        public string id { get; set; }

        [XmlElement("inn")]
        public string inn { get; set; }

        [XmlElement("kpp")]
        public string kpp { get; set; }

        [XmlElement("date_accept")]
        public string date_accept { get; set; }

    }

    [XmlRoot("companies")]
    public class Companies
    {
        [XmlElement("company")]
        public Company[] company { get; set; }
    }
}
