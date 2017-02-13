using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3
{
    abstract class Nisakas 
    {
        
        public int Ika { get; set; }
        
        public abstract void Liiku();
    }
    class Ihminen : Nisakas
    {
        
        public string Nimi { get; set; }

        public int Pituus { get; set; }

        public int Paino { get; set; }
        
        public override void Liiku()
        {
            Console.WriteLine("Hei, minä liikun!");
        }
        public void Kasva()
        {
            Ika += 1;
        }
    }
    class Vauva: Ihminen
    {
        
        public string Vaipat { get; set; }
        
        public Vauva(string nimi, int ika, int pituus, int paino, string vaipat)
        {
            Nimi = nimi;
            Ika = ika;
            Pituus = pituus;
            Paino = paino;
            Vaipat = vaipat;
        }
        
        public override void Liiku()
        {
            Console.WriteLine("Hei, minä ryömin!");
        }

        public override string ToString()
        {
            return String.Format("Hei, olen {0}, olen {1} vuotta, olen {2}cm pitkä, painan {3}kiloa ja käytän {4}.", Nimi, Ika, Pituus, Paino, Vaipat);
        }
    }
    class Aikuinen : Ihminen
    {
        
        public string Car { get; set; }
        //constructor
        public Aikuinen(string nimi, int ika, int pituus, int paino)
        {
            Nimi = nimi;
            Ika = ika;
            Pituus = pituus;
            Paino = paino;
            
        }
        //methods
        public override void Liiku()
        {
            Console.WriteLine("Hei, minä kävelen!");
        }
        public override string ToString()
        {
            return String.Format("Hei, olen {0}, olen {1} vuotta vanha, olen {2}cm pitkä ja painan {3}kg.", Nimi, Ika, Pituus, Paino);
        }
    }
}