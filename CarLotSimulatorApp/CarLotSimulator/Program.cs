using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            // DONE Create a seperate class file called Car
            // DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            // DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            // DONE The methods should take one string parameter: the respective noise property


            // DONE Now that the Car class is created we can instanciate 3 new cars
            // DONE Set the properties for each of the cars

            var car1 = new Car();
            car1.Year = 2015;
            car1.Make = "Ford";
            car1.Model = "F150";
            car1.EngineNoise = "VROOM (Trucks are too loud)";
            car1.HonkNoise = "honk";
            car1.IsDriveable = true;

            var car2 = new Car()
            {
                Year = 2020,
                Make = "Toyota",
                Model = "Prius",
                EngineNoise = "..... (hybrid cars are quiet)",
                HonkNoise = "chirp",
                IsDriveable = true,
            };

            var car3 = new Car();
            car3.Year = 1995;
            car3.Make = "Toyota";
            car3.Model = "Camry";
            car3.EngineNoise = "vroom (this car is appropriately loud";
            car3.HonkNoise = "honk";
            car3.IsDriveable = false;

            // DONE Call each of the methods for each car
            car1.MakeEngineNoise(car1.EngineNoise);
            car2.MakeEngineNoise(car2.EngineNoise);
            car3.MakeEngineNoise(car3.EngineNoise);

            car1.MakeHonkNoise(car1.HonkNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            car3.MakeHonkNoise(car3.HonkNoise);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
