using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KostasExplorer
{
    class OneItem
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public DateTime DateModified { get; set; }
        public FileAttributes Type { get; set; }
    }
}
