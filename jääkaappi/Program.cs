using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jääkaappi
{
    class Program
    {
        static void Main(string[] args)
        {
            jaakaappi Ruusenloovi = new jaakaappi();
            Console.WriteLine(Ruusenloovi.ToString());
            Ruusenloovi.AvaaOvi();

            Tavarat k = new Tavarat("Ketsuppi");
            Tavarat s = new Tavarat("Salaatti");

            Ruusenloovi.AddTavarat(k);
            Ruusenloovi.AddTavarat(s);

            Console.WriteLine(Ruusenloovi.ToString());
            
        }
    }
}
