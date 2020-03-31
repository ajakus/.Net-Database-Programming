using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class FarmerJoe : Driver
    {
        public FarmerJoe(RaceCar car) : base(car)
        {
            Name = "Farmer Joe";
            SkillLevel = 3;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
