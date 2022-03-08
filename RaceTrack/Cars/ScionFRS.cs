using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class ScionFRS : RaceCar
    { 
        public ScionFRS()
        {
            Name = "Scion FR-S";
            TopSpeed = 200;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} roars to life!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} ends in position {Position}!");
        }
    }
}
