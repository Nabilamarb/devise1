using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevise d = new MAD(10);
            Console.WriteLine("la valeur en euro est :" + d.Convertto("Euro").ToString());
            Console.WriteLine("la valeur en dollar est :" + d.Convertto("Dollar").ToString());
            Console.ReadKey();

        }
    }
}
