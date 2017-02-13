using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jääkaappi
{
    public class jaakaappi
    {

        // properties
        private bool OviAuki { get; set; }
        private string OvenTilanne
        {
            get
            {
                if (OviAuki) { return "auki"; }
                else { return "kiinni"; }
            }
        }
        private string Valo
        {
            get
            {
                if (OviAuki)
                    return "valo päällä";
                else
                    return "valo ei ole päällä";


            }
        }
        public List<Tavarat> Sisalto;

        public jaakaappi()
        {
            Sisalto = new List<Tavarat>();
        }
        public void AvaaOvi()
        {
            if (OviAuki) { OviAuki = false; }
            else { OviAuki = true; }
        }
        public void AddTavarat(Tavarat tavarat)
        {
            Sisalto.Add(tavarat);

        }
        public override string ToString()
        {

            string retval = String.Format("Jääkaappi on {0} ja valo on {1}. Tavarat jääkaapissa: ", OvenTilanne, Valo);
            foreach (Tavarat tavarat in Sisalto)
            {
                retval += "\n" + tavarat.ToString();
            }
            return retval;
        }

    }
    public class Tavarat
    {
        public string Name { get; set; }

        public Tavarat(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return String.Format("Tavaran nimi: {0}. ", Name); 

        }
    }
    
}
