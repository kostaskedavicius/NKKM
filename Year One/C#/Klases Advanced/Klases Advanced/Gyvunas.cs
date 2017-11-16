using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases_Advanced
{
    abstract class Gyvunas
    {
        public byte KojuSkaicius { get; set; }
        public string Spalva { get; set; }
        public bool ArYraUodega { get; set; }
        public abstract float Kaina { get; }

        public virtual string Aprasymas()
        {
            return "Grazus gyvunas";
        }

        public abstract void SiulytiKaina(float kaina);

    }
}
