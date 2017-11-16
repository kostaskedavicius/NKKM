using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases_Advanced
{
    class Suo : Gyvunas
    {
        private float kaina;
        public override float Kaina
        {
            get
            {
                return kaina;
            }
        }

        public string Veisle { get; set; }


        public override string Aprasymas()
        {
            return "Geras suo";
        }

        public override void SiulytiKaina(float kaina)
        {
            if (kaina < 100)
            {
                this.kaina = 100;
            }
            else
            {
                this.kaina = kaina;
            }
        }
    }
}
