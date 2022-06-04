using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{
     class MAD : Devise
    {
        private static double tauxEuro = 0.010;
        private static double tauxDollar = 9.09;


        public MAD(double v) : base(v, "MAD")
        {

        }
        public override Devise Convertto(string symbole)
        {
            Devise res;
            if(symbole == "Euro")
            {
                res = new Euro(this.valeur * tauxEuro);
            }
            else if(symbole == "Dollar")
            {
                res = new Dollar(this.valeur * tauxDollar);
            }
            else
            {
                res = this;
            }
            return res;
        }
    }
}
