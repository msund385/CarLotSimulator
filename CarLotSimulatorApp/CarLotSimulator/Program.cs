namespace CarLotSimulator
{
    using System;
    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {
            var lot = new CarLot();
            
          //Instantation 1 - using Dot Notation
            var michaelsCar = new Car();
            michaelsCar.Make = "Honda";
            michaelsCar.Model = "Accord";
            michaelsCar.Year = 1996;
            michaelsCar.EngineNoise = "Vrooooom";
            michaelsCar.HonkNoise = "Beeeep";
            michaelsCar.IsDrivable = true;

            lot.Cars.Add(michaelsCar);

            var stevesCar = new Car()
            { //object Initializer Syntax
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "---",
                HonkNoise = "brump",
                IsDrivable = false,

            };
            lot.Cars.Add(stevesCar);
            //Using the constructor to allow parameter values to be placed inside properties
            var brettsCar = new Car(2013, "Honda", "Civic", "vrooom", "vruuga", true);

            lot.Cars.Add(brettsCar);
            //TODO

            //Done!Create a seperate class file called Car
            //done! Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Done! Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            // Done! The methods should take one string parameter: the respective noise property


            //Done! Now that the Car class is created we can instanciate 3 new cars
            //Done! Set the properties for each of the cars
            //Done!Call each of the methods for each car
             michaelsCar.MakeEngineNoise();
             stevesCar.MakeEngineNoise();
             brettsCar.MakeEngineNoise();

              
            //*************BONUS*************//

            // Done! Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//
            Console.WriteLine($"Number of cars created {CarLot.numberOfCars}");

            //Done! Create a CarLot class
            //Done!It should have at least one property: a List of cars
            //Done!Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach(var car in lot.Cars)
            {

                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}

Generic;
