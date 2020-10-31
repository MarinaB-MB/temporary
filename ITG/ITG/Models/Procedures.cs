using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ITG.Models
{
    public class Procedure : Procedures
    {
        [XmlElement("registry_number")]
        public string registry_number { get; set; }

        [XmlElement("number")]
        public string number { get; set; }

        [XmlElement("status")]
        public string status { get; set; }

    }

    [XmlRoot("procedures")]
    public class Procedures
    {
        [XmlElement("procedure")]
        public Procedure[] procedure { get; set; }
    }
}
