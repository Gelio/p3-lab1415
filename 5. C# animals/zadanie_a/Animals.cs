using System;

namespace PO_Lab5
{
    // Napisać abstrakcyjną klasę Toy
    // a w niej publiczne abstrakcyjne bezparametrowe metody Play i Eat

    abstract class Toy
    {
        abstract public void Play();
        abstract public void Eat();
    }

    // Napisać klasy Bone i FurryBall dziedziczące z Toy
    // Metody klasy Bone działają w następujący sposób
    //  Play wypisuje na konsolę "Playing with bone."
    //  Eat wypisuje na konsolę "Yummy bone."

    class Bone : Toy
    {
        public override void Play()
        {
            Console.WriteLine("Playing with a bone.");
        }

        public override void Eat()
        {
            Console.WriteLine("Yummy bone.");
        }
    }

    // Metody klasy FurryBall działają w następujący sposób
    //  Play wypisuje na konsolę "Playing with furry ball."
    //  Eat wypisuje na konsolę "Bleh this is un-eatable."

    class FurryBall : Toy
    {
        public override void Play()
        {
            Console.WriteLine("Playing with furry ball.");
        }

        public override void Eat()
        {
            Console.WriteLine("Bleh this is un-eatable.");
        }
    }

    // Napisać abstrakcyjną klasę Animal
    // z następującymi składowymi
    // - publiczne pole Name typu string (pole readonly)
    // - konstruktor z parametrem typu string (imię zwierzęcia)
    // - wirtualna bezparametrowa metoda Play
    //     wypisująca na konsolę "Animal {Name} is playing alone"
    // - abstrakcyjna metoda Play z parametrem typu Toy
    // - abstrakcyjna bezparametrowa metoda Speak


    abstract class Animal
    {
        public readonly string Name;

        public Animal(string name)
        {
            this.Name = name;
        }

        virtual public void Play()
        {
            Console.WriteLine("Animal {0} is playing alone", this.Name);
        }

        abstract public void Play(Toy t);

        abstract public void Speak();

    }

    // Napisać klasy Dog i Cat dzidziczące z klasy Animal
    // obie klasy powinny zawierać konstruktor wskazujący imię zwierzęcia

    // Metody klasy Dog działają w następujący sposób:
    //  Speak wypisuje na konsolę "{Name}: woof, woof"
    //  bezparametrowa metoda Play nie jest nadpisana
    //  metada Play przyjmująca jako parametr Toy - wypisuje na konsolę "{Name} is eating toy: " i wywołuje metodę Eat na parametrze.

    class Dog : Animal
    {
        public Dog(string name):base(name)
        {
            
        }

        public override void Play(Toy t)
        {
            Console.WriteLine("{0} is eating toy: ", this.Name);
            t.Eat();
        }

        public override void Speak()
        {
            Console.WriteLine("{0}: woof, woof", this.Name);
        }
    }


    // Metody klasy Cat działają w następujący sposób:
    //  Speak wypisuje na konsolę "{Name}: mew, mew"
    //  bezparametrowa metoda Play wypisuję na konsolę "{Name}: I want a toy !!!"
    //  metada play przyjmująca jako parametr Toy - wypisuje na konsolę "{Name} is playing with a toy: " i wywołuje metodę Play na parametrze.

    class Cat : Animal
    {
        public Cat(string name):base(name)
        {

        }

        public override void Play()
        {
            Console.WriteLine("{0}: I want a toy !!!", this.Name);
        }

        public override void Play(Toy t)
        {
            Console.WriteLine("{0} is playing with a toy: ", this.Name);
            t.Eat();
        }

        public override void Speak()
        {
            Console.WriteLine("{0}: mew, mew", this.Name);
        }
    }

}
