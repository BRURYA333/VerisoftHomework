using System;

namespace VerisoftWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal Test Suite");

            // Test for Dog
            TestDog();

            // Test for Cat
            TestCat();

            // Test for Frog
            TestFrog();

            Console.WriteLine("\nAll tests completed successfully!");
        }

        static void TestDog()
        {
            Console.WriteLine("\nTesting Dog:");

            // Create a Dog instance
            Dog dog = new Dog(mammals: true, carnivorous: true, mood: 1);

            // Test inherited properties
            Console.WriteLine($"Is Dog a mammal? {dog.isMammals()} (Expected: True)");
            Console.WriteLine($"Is Dog carnivorous? {dog.isCarnivorous()} (Expected: True)");

            // Test methods
            Console.WriteLine("Dog says hello:");
            dog.sayHello();  // Expected output: wagging tails

            Console.WriteLine("Dog with happy mood:");
            dog.sayHello(1); // Expected output: Barking loudly

            Console.WriteLine("Dog with scared mood:");
            dog.sayHello(2); // Expected output: whooping
        }

        static void TestCat()
        {
            Console.WriteLine("\nTesting Cat:");

            // Create a Cat instance
            Cat cat = new Cat(mammals: true, carnivorous: true, mood: 1);

            // Test inherited properties
            Console.WriteLine($"Is Cat a mammal? {cat.isMammals()} (Expected: True)");
            Console.WriteLine($"Is Cat carnivorous? {cat.isCarnivorous()} (Expected: True)");

            // Test methods
            Console.WriteLine("Cat says hello:");
            cat.sayHello();  // Expected output: meow

            Console.WriteLine("Cat with happy mood:");
            cat.sayHello(1); // Expected output: purr

            Console.WriteLine("Cat with scared mood:");
            cat.sayHello(2); // Expected output: hiss
        }

        static void TestFrog()
        {
            Console.WriteLine("\nTesting Frog:");

            // Create a Frog instance
            Frog frog = new Frog(mammals: false, carnivorous: false, mood: 1);

            // Test inherited properties
            Console.WriteLine($"Is Frog a mammal? {frog.isMammals()} (Expected: False)");
            Console.WriteLine($"Is Frog carnivorous? {frog.isCarnivorous()} (Expected: False)");

            // Test Water interface methods
            Console.WriteLine($"Does Frog have gills? {frog.hasGills()} (Expected: False)");
            Console.WriteLine($"Does Frog lay eggs? {frog.hasLaysEggs()} (Expected: True)");

            // Test methods
            Console.WriteLine("Frog with happy mood:");
            frog.sayHello(1); // Expected output: quack quack quack

            Console.WriteLine("Frog with scared mood:");
            frog.sayHello(2); // Expected output: plop into the water
        }
    }
}
