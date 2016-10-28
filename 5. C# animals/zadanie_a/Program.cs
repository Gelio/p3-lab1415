using System;

namespace PO_Lab5
{
	class Program
	{
		static void Main()
		{
            Animal[] animals = { new Dog("Odie"), new Cat("Garfield"), new Dog("Dogbert"), };

            //// Etap 1 (2p.)
            Console.WriteLine("\nAnimals speak:");
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Speak();
            }

            //// Etap 2 (1p.)
            Console.WriteLine("\nAnimals play:");
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Play();
            }

            //// Etap 3 (2p.)
            Toy[] toys = { new Bone(), new FurryBall() };

            Console.WriteLine("\nAnimals play with toys:");
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < toys.Length; j++)
                {
                    animals[i].Play(toys[j]);
                }
            }

            Console.WriteLine();
		}
	}
}
