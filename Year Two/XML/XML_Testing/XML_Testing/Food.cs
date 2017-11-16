using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_Testing
{
    public class Food
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public String Description { get; set; }
        public int Calories { get; set; }
        public List<Ingredients> Ingreds { get; set; }
    }
}
