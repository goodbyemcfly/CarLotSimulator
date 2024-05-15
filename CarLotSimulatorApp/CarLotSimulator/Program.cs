using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot(); 
            //TODO

            // DONE Create a seperate class file called Car
            // DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            // DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            // DONE The methods should take one string parameter: the respective noise property


            // DONE Now that the Car class is created we can instanciate 3 new cars
            // DONE Set the properties for each of the cars

            Console.WriteLine($"The current number of cars in the lot is: {CarLot._numberOfCars}");
            Console.WriteLine();

            var carOne = new Car();
            carOne.Year = 2015;
            carOne.Make = "Ford";
            carOne.Model = "F150";
            carOne.EngineNoise = "VROOM (Trucks are too loud)";
            carOne.HonkNoise = "honk";
            carOne.IsDriveable = true;

            carLot.ParkingLot.Add(carOne);
            Console.WriteLine($"The first car we will add to the lot is a {carOne.Year} {carOne.Make} {carOne.Model}");

            Console.WriteLine($"The current number of cars in the lot is: {CarLot._numberOfCars}");
            Console.WriteLine();

            var carTwo = new Car()
            {
                Year = 2020,
                Make = "Toyota",
                Model = "Prius",
                EngineNoise = "..... (hybrid cars are quiet)",
                HonkNoise = "chirp",
                IsDriveable = true,
            };

            carLot.ParkingLot.Add(carTwo);
            Console.WriteLine($"The second car we will add to the lot is a {carTwo.Year} {carTwo.Make} {carTwo.Model}");

            Console.WriteLine($"The current number of cars in the lot is: {CarLot._numberOfCars}");
            Console.WriteLine();

            var carThree = new Car();
            carThree.Year = 1995;
            carThree.Make = "Toyota";
            carThree.Model = "Camry";
            carThree.EngineNoise = "vroom (this car is appropriately loud";
            carThree.HonkNoise = "honk";
            carThree.IsDriveable = false;

            carLot.ParkingLot.Add(carThree);
            Console.WriteLine($"The third car we will add to the lot is a {carThree.Year} {carThree.Make} {carThree.Model}");

            Console.WriteLine($"The current number of cars in the lot is: {CarLot._numberOfCars}");
            Console.WriteLine();

            Console.WriteLine("Here is a list of all the cars we have in the lot.");
            carLot.CheckCars();

            // DONE Call each of the methods for each car
            //carOne.MakeEngineNoise(carOne.EngineNoise);
            //carTwo.MakeEngineNoise(carTwo.EngineNoise);
            //carThree.MakeEngineNoise(carThree.EngineNoise);

            //carOne.MakeHonkNoise(carOne.HonkNoise);
            //carTwo.MakeHonkNoise(carTwo.HonkNoise);
            //carThree.MakeHonkNoise(carThree.HonkNoise);

            // DONE Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
