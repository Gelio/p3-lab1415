using System;

namespace PO_Lab5
{
	// Napisać abstrakcyjną klasę Toy
	// a w niej publiczne abstrakcyjne bezparametrowe metody Play i Eat

	abstract class Toy
	{
	abstract 
	}
	
		abstract class Animal
		{
		public readonly string Name;
		
		public Toy(string nm):Toy(nm);
		
		virtual void Play()
		{
			Console.WriteLine("Animal ");
			Console.WriteLine(Name);
			Console.WriteLine(" is playing alone");
		}
		
		abstract void Play(Toy t);
		
		abstract void Speak();
				
		}
		
		class Dog:Animal
		{
		
		}
		
		class Cat:Animal
		{
		
		}
	
	// Napisać abstrakcyjną klasę Animal
	// z następującymi składowymi
	// - publiczne pole Name typu string (pole readonly)
	// - konstruktor z parametrem typu string (imię zwierzęcia)
	// - wirtualna bezparametrowa metoda Play
	//     wypisująca na konsolę "Animal {Name} is playing alone"
	// - abstrakcyjna metoda Play z parametrem typu Toy
	// - abstrakcyjna bezparametrowa metoda Speak

	// Napisać klasy Dog i Cat dzidziczące z klasy Animal
	// obie klasy powinny zawierać konstruktor wskazujący imię zwierzęcia

	// Metody klasy Dog działają w następujący sposób:
	//  Speak wypisuje na konsolę "{Name}: woof, woof"
	//  bezparametrowa metoda Play nie jest nadpisana
	//  metada Play przyjmująca jako parametr Toy - wypisuje na konsolę "{Name} is eating toy: " i wywołuje metodę Eat na parametrze.

	// Metody klasy Cat działają w następujący sposób:
	//  Speak wypisuje na konsolę "{Name}: mew, mew"
	//  bezparametrowa metoda Play wypisuję na konsolę "{Name}: I want a toy !!!"
	//  metada play przyjmująca jako parametr Toy - wypisuje na konsolę "{Name} is playing with a toy: " i wywołuje metodę Play na parametrze.

	// Napisać klasy Bone i FurryBall dziedziczące z Toy
	// Metody klasy Bone działają w następujący sposób
	//  Play wypisuje na konsolę "Playing with bone."
	//  Eat wypisuje na konsolę "Yummy bone."

	// Metody klasy FurryBall działają w następujący sposób
	//  Play wypisuje na konsolę "Playing with furry ball."
	//  Eat wypisuje na konsolę "Bleh this is un-eatable."


}
