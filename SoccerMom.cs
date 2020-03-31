using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class SoccerMom : Driver
    {
        public SoccerMom(RaceCar car) : base(car)
        {
            Name = "Soccer Mom";
            SkillLevel = 6;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
