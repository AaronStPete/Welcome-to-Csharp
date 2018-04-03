using System;

namespace Welcome_to_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte runningDogs = 5;
            Console.WriteLine($"There are {runningDogs} running dogs in the dog park.");

            short sandwiches = 10000;
            Console.WriteLine($"I could gobble {sandwiches} sandwiches when I'm hungry.");

            float dinnerPrice = 42.99f;
            Console.WriteLine($"Dinner tonight costs ${dinnerPrice}");

            string carColor = "Metallic Blue";
            string carMake = "Chevy";
            string carModel = "Corvette";
            Console.WriteLine($"My dream car would be a {carMake} {carModel} in {carColor}");

            string date = DateTime.Today.ToShortDateString();
            Console.WriteLine($"Today's date is: {date}");

            char firstLetter = 'a';
            Console.WriteLine($"The first letter of my name starts with an '{firstLetter}'.");            

            float stars = 9096;
            Console.WriteLine($"There are {stars} stars in the visible sky.");

            Console.ReadLine();

        }
    }
}
