using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace XML_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            // We can serialize only public fields and properties, classes must be public too. Serialization does not include type information. To serialize an object there must be a default constructor(non-parameterised). We cannot serialize Read-Only properties

            var addr = new Address();
            addr.City = "Vilnius";
            addr.Country = "Lietuva";
            addr.StreetName = "Lakunu g.";
            addr.HouseNumber = "24";
            addr.ZipCode = "09108";

            XmlSerializer xml = new XmlSerializer(addr.GetType());
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Address.xml";
            using (TextWriter writer = new StreamWriter(path))
            {
                xml.Serialize(writer, addr);
            }
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            List<Food> list = new List<Food>()
            {
                new Food()
                {
                    Name = "Hot-Dog",
                    Price = 2.99f,
                    Description = "Hot and tasty",
                    Calories = 1200
                },
                new Food()
                {
                    Name = "Pizza slice",
                    Price = 4.99f,
                    Description = "Only one slice even if we showed a full pizza in the advert",
                    Calories = 1000
                }
            };


            XmlSerializer xml = new XmlSerializer(list.GetType());
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Food.xml";
            using (TextWriter writer = new StreamWriter(path))
            {
                xml.Serialize(writer, list);
            }
        }

        private void btnFood2_Click(object sender, EventArgs e)
        {
            List<Food> list = new List<Food>()
            {
                new Food()
                {
                    Name = "Hot-Dog",
                    Price = 2.99f,
                    Description = "Hot and tasty",
                    Calories = 1200
                },
                new Food()
                {
                    Name = "Pizza slice",
                    Price = 4.99f,
                    Description = "Only one slice even if we showed a full pizza in the advert",
                    Calories = 1000
                }
            };
            List<Ingredients> hotdog = new List<Ingredients>()
            {
                new Ingredients()
                {
                    Name = "Bread",
                    Calories = 100
                },
                 new Ingredients()
                {
                    Name = "Spices",
                    Calories = 50
                },
                  new Ingredients()
                {
                    Name = "Dog",
                    Calories = 1050
                }
            };
            list[0].Ingreds = hotdog;

            XmlSerializer xml = new XmlSerializer(list.GetType());
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\FoodWithIngredients.xml";
            using (TextWriter writer = new StreamWriter(path))
            {
                xml.Serialize(writer, list);
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Address.xml";
            var addr = new Address();
            XmlSerializer xml = new XmlSerializer(addr.GetType());

            using (TextReader reader = new StreamReader(path))
            {
                addr = xml.Deserialize(reader) as Address;
                MessageBox.Show(addr.City);
            }
        }
    }
}
