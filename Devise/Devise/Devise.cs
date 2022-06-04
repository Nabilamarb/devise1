using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{
    abstract class Devise : IDevise
    {
        protected double valeur;
        private string type;
        abstract public Devise Convertto(string symbole);
        public Devise(double v, string t)
        {
            this.valeur = v;
            this.type = t;
        }
        public override string ToString()
        {
            string s = "la valeur est:"+this.valeur+ "+\n"+
                "le type :" + this.type;
            return s;
        }

    }
}
