using Harjoitus3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Aikuinen henkilo = new Aikuinen("Jaska", 41, 165, 140);
           Vauva vauva = new Vauva("Elviira", 1, 75, 18, "Eloveena");
            
            Console.WriteLine(henkilo.ToString());
            Console.WriteLine(vauva.ToString());
            //move them
            henkilo.Liiku();
            vauva.Liiku();
            //birthday time
            henkilo.Kasva();
            vauva.Kasva();
            //display info
            Console.WriteLine(henkilo.ToString());
            Console.WriteLine(vauva.ToString());
        }
    }
}