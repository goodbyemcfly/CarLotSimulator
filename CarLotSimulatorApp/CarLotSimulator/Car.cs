using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"The {Make} {Model} has an engine noise that sounds like '{engineNoise}'");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"The {Make} {Model} has a honk noise that sounds like '{honkNoise}'");
        }

        public Car()
        {
            CarLot._numberOfCars++;
        }
    }

}
