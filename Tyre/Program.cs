using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;
/// <summary>
/// TESTATAAN TYRE JA VEHICLE LUOKKIA
/// LABRA 05
/// 7.2.2017
/// </summary>

namespace Excercise01
{

    class Program
    {
        static void Main(string[] args)
        {
            //create first vehicle
            Vehicle car = new Vehicle();
            car.Brand = "BMW";
            car.Model = "320";
            //buy rear wheels
            Tyre loopie = new Tyre();
            loopie.Brand = "Hankook";
            loopie.Size = "205/55R16";
            //put 2 reartyres to the BMW
            car.AddTyre(loopie);
            car.AddTyre(loopie);

            //show car info
            Console.WriteLine("Your car {0} has the following information: {1}", car.Brand, car.ToString());

            //buy front wheels
            Tyre slicks = new Tyre();
            slicks.Brand = "Michelin";
            slicks.Size = "210/50R16";
            //install new front tyres
            car.AddTyre(slicks);
            car.AddTyre(slicks);
            //show car info
            Console.WriteLine("Your car {0} has the following information: {1}", car.Brand, car.ToString());
        }
    }
}