using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    class Gary : Driver
    {
            public Gary(RaceCar car) : base(car)
            {
                Name = "Gary";
                SkillLevel = 20;
            }

            public override void Drive()
            {
                Car.Accelerate(SkillLevel);
            }
        }
}
