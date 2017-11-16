using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_Testing
{
    [XmlRoot("Adresas")]
    public class Address
    {
        [XmlElement("Gatve")]
        public string StreetName { get; set; }
        [XmlElement("Namas")]
        public string HouseNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        [XmlAttribute("Salis")]
        public string Country { get; set; }       
    }
}
