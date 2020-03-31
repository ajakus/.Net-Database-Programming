using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Tractor : RaceCar
    {
        public Tractor()
        {
            Name = "Tractor";
            TopSpeed = 20;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} struggles to start");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} is having a hard time stopping!");
            base.Brake();
        }
    }
}
