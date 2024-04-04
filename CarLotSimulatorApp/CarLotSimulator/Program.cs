using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars

            var customerCar = new car("Kia", "Optima", 2023, true, "Vroom", "Honk");
            var customerCar1 = new car("Honda", "Civic", 2010, false, "Vroom", "Beep");
            var customerCar2 = new car("Toyota", "Prius", 2012, true, "", "Honk");
            //Set the properties for each of the cars
            //Call each of the methods for each car

            customerCar.MakeEngineNoise(customerCar.EngineNoise);
            customerCar.MakeEngineNoise(customerCar.HonkNoise)

            customerCar1.MakeEngineNoise(customerCar1.EngineNoise);
            customerCar1.MakeHonkVoice(customerCar1.HonkNoise);

            customerCar2.MakeEngineNoise(customerCar2.EngineNoise);
            customerCar2.MakeHonkVoice(customerCar2.HonkNoise);


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
