using System;

namespace VerisoftWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal Test Suite");

            // Create a Dog instance
            Dog dog = new Dog(mammals: true, carnivorous: true, mood: 1);

            // Create a Cat instance
            Cat cat = new Cat(mammals: true, carnivorous: true, mood: 1);

            // Create a Frog instance
            Frog frog = new Frog(mammals: false, carnivorous: false, mood: 1);

            //Test abstract animal class
            List<Animal> animals = new List <Animal> { dog, cat, frog };

            //Test Interface water 
            List<Water> waterAnimals = new List<Water> { };

            //Test Interface land 
            List<Land> landAnimals = new List<Land> { };

            int counterCarn = 0;
            
            for(int i = 0; i < animals.Count; i++)
            {
                if (animals[i].isCarnivorous())
                    counterCarn++;

                if (animals[i] is Water)
                {
                    waterAnimals.Add((Water)animals[i]);
                }

                if (animals[i] is Land)
                {
                    landAnimals.Add((Land)animals[i]);
                }


                Console.WriteLine($"{animals[i].GetType().Name} says hello:");

                animals[i].sayHello(); 

                Console.WriteLine($"{animals[i].GetType().Name} with happy mood:");
                animals[i].sayHello(Animal.MOOD_HAPPY);

                Console.WriteLine($"{animals[i].GetType().Name} with scared mood:");
                animals[i].sayHello(Animal.MOOD_SCARE); 
            }

            int counterGills = 0;
            int counterLaysEggs = 0;
            int counterHas4Legs = 0;

            for (int i = 0;i < waterAnimals.Count; i++)
            {
                if (waterAnimals[i].hasGills())
                {
                    counterGills++;
                }
                if (waterAnimals[i].hasLaysEggs())
                {
                    counterLaysEggs++;
                }

            }

            for (int i = 0; i < landAnimals.Count; i++)
            {
                if (landAnimals[i].getNumberOfLegs()==4)
                {
                    counterHas4Legs++;
                }
            }

            Console.WriteLine($"number of animals with a gills is {counterGills} (Expected: 1)");
            Console.WriteLine($"number of carnivorous animals is {counterCarn} (Expected: 2)");
            Console.WriteLine($"number of animals with four legs is {counterHas4Legs} (Expected: 3)"); 

            Console.WriteLine("\nAll tests completed successfully!");
        }

    }
}
