using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Vehicle
    {
        //constants and variables
        private const int maxTyres = 4;
        private int countTyres = 0;
        //properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public Tyre[] Tyres { get; }
        //constructors
        public Vehicle()
        {
            Tyres = new Tyre[maxTyres];
        }
        //methods
        public void AddTyre(Tyre tyre)
        {
            if (countTyres < maxTyres)
            {
                Tyres[countTyres] = tyre;
                countTyres++;
                Console.WriteLine("Tyre {0} added to vehicle {1}", tyre.ToString(), this.Brand);
            }
            else
            {
                Console.WriteLine("Cannot add tyres!");
            }
        }
        public override string ToString()
        {
            string retval = "Car maker: " + Brand + " Model:" + Model + "\nTyres: ";
            foreach (Tyre tyre in Tyres)
            {
                if (tyre != null)
                {
                    retval += "\n" + tyre.ToString();
                }
            }
            return retval;
        }
    }
    public class Tyre
    {
        //variables
        public string Brand { get; set; }
        public string Size { get; set; }
        //method
        public override string ToString()
        {
            return String.Format("Brand is: {0}. Size is {1}", Brand, Size);
        }
    }

}