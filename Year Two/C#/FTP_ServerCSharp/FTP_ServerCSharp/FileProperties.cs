using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FTP_ServerCSharp
{
    enum Types
    {
        File,
        Folder,
        Link
    }

    class FileProperties
    {
        public string Name { get; set; }
        public float Size { get; set; }
        public Types Type { get; set; }


        public static List<FileProperties> GetDetails(Stream FtpSream)
        {
            List<FileProperties> temp = new List<FileProperties>();
            StreamReader reader = new StreamReader(FtpSream);
            while (!reader.EndOfStream)
            {
                // Read one line
                string line = reader.ReadLine();
                // Split lite
                string[] rez = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                FileProperties fileProperties = new FileProperties();
                fileProperties.Name = rez[8];
                fileProperties.Size = Convert.ToSingle(rez[4]);
                switch (rez[0][0])
                {
                    case 'd':
                        fileProperties.Type = Types.Folder;
                        break;
                    case 'l':
                        fileProperties.Type = Types.Link;
                        break;
                    default:
                        fileProperties.Type = Types.File;
                        break;
                }
                temp.Add(fileProperties);
            }
            reader.Close();
            return temp;
        }
    }
}
