using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases_Advanced
{
    class Gyvate : Gyvunas
    {
        public override float Kaina
        {
            get
            {
                return 1000000000000;
            }
        }

        public string Rusis { get; set; }

        public override void SiulytiKaina(float kaina)
        {
            
        }
    }
}
