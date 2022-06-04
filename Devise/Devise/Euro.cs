using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{
     class Euro:Devise
    {
        private static double tauxDollar =10.00;
        private static double tauxMad = 1.09;


        public Euro(double v) : base(v, "Euro")
        {

        }
        public override Devise Convertto(string symbole)
        {
            Devise res;
            if (symbole == "Dollar")
            {
                res = new Dollar(this.valeur * tauxDollar);
            }
            else if (symbole == "Mad")
            {
                res = new MAD(this.valeur * tauxMad);
            }
            else
            {
                res = this;
            }
            return res;
        }
    }
}
