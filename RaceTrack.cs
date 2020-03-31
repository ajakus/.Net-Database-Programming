using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;
using RaceTrack.RaceTrack.Drivers;

namespace RaceTrack.RaceTrack
{
    public class RaceTrack
    {

        public List<Driver> Drivers { get; set; }
        public int NumberOfLaps { get; set; }

        public RaceTrack(int numberOfLaps)
        {
            NumberOfLaps = numberOfLaps;
            Drivers = new List<Driver>();
        }

        public void PositionCars()
        {
            Drivers.Add(new FarmerJoe(new Tractor()));
            Drivers.Add(new Antonio(new FordGt()));
            Drivers.Add(new SoccerMom(new Minivan()));
        }

        public void DriversReady()
        {
            foreach (var driver in Drivers)
            {
                driver.StartEngine();
            }
            Thread.Sleep(1000);
        }

        public void StartRace()
        {
            foreach (var driver in Drivers)
            {
                driver.Drive();
            }
            Thread.Sleep(1000);
        }

        public void AnnouncePositions()
        {
            foreach (var driver in Drivers)
            {
                driver.Accelerate();
            }
            Thread.Sleep(1000);
        }

        public void EndRace()
        {
            foreach (var driver in Drivers)
            {
                driver.Stop();
            }
            Thread.Sleep(1000);
        }

        public void AnnounceWinners()
        {
            var position = 0;
            Console.WriteLine();
            Console.WriteLine("The winners are ...");
            foreach (var driver in Drivers.OrderByDescending(d => d.Car.Position))
            {
                if (driver.Car.Position == 0)
                {
                    Console.WriteLine($"Oh no! {driver.Name} suffered a breakdown in their {driver.Car.Name} and didn't finish the race!");
                }
                else
                { 
                    Console.WriteLine($"{++position}: {driver.Name} in their {driver.Car.Name}");
                }
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
