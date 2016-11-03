using System;

namespace PO_Lab5
{
	// Napisać abstrakcyjną klasę Jedzenie
	// a w niej publiczne abstrakcyjne bezparametrowe metody Pogryz i Polknij

    abstract class Jedzenie
    {
        public abstract void Pogryz();
        public abstract void Polknij();
    }

	// Napisać abstrakcyjną klasę Zwierze
	// z następującymi składowymi
	// - publiczne pole Imie typu string (pole readonly)
	// - konstruktor z parametrem typu string (imię zwierzęcia)
	// - wirtualna bezparametrowa metoda Jedz
	//     wypisująca na konsolę "Zwierzę {Imie} liżę łapę"
	// - abstrakcyjna metoda Jedz z parametrem typu Jedzenie
	// - abstrakcyjna bezparanetrowa metoda DajGlos

    abstract class Zwierze
    {
        public readonly string Imie;

        public Zwierze(string _imie)
        {
            this.Imie = _imie;
        }

        public virtual void Jedz()
        {
            Console.WriteLine("Zwierzę {0} liże łapę", this.Imie);
        }

        public abstract void Jedz(Jedzenie jedzenie);
        public abstract void DajGlos();
    }

    // Napisać klasy Pies i Kot dziedziczące z klasy Zwierze
    // obie klasy powinny zawierać konstruktor wskazujący imię zwierzęcia

    // Metody klasy Pies działają w następujący sposób:
    //  DajGlos wypisuje na konsolę "{Imie}: szczek, szczek"
    //  bezparametrowa metoda Jedz wypisuję na konsolę "{Imie}: Nie będę lizał łapy chcę coś do jedzenia"
    //  metada Jedz przyjmująca jako parametr Jedzenie - wypisuje na konsolę "{Imie} {0} połyka jedzenie: " i wywołuje metodę Polknij na parametrze.
    class Pies : Zwierze
    {
        public Pies(string _imie):base(_imie) { }

        public override void Jedz()
        {
            Console.WriteLine("{0}: Nie będę lizał łapy chce coś do jedzenia", base.Imie);
        }

        public override void Jedz(Jedzenie jedzenie)
        {
            Console.WriteLine("{0} polyka jedzenie: ", base.Imie);
            jedzenie.Polknij();
        }

        public override void DajGlos()
        {
            Console.WriteLine("{0}: szczek, szczek", base.Imie);
        }
    }

    // Metody klasy Kot dzialają w następujący sposób:
    //  DajGlos wypisuje na konsolę "{Imie}: miau, miau"
    //  bezparametrowa metod Jedz nie jest nadpisana
    //  metada Jedz przyjmująca jako parametr Jedzenie - wypisuje na konsolę "{Imie} gryzie Jedzenie: " i wywołuje metodę Jedz na parametrze.
    //                                                                                                                     ^^^ chyba Pogryz
    class Kot : Zwierze
    {
        public Kot(string _imie) : base(_imie) { }

        public override void Jedz(Jedzenie jedzenie)
        {
            Console.WriteLine("{0} gryzie jedzenie: ", base.Imie);
            jedzenie.Pogryz();
        }

        public override void DajGlos()
        {
            Console.WriteLine("{0}: miau, miau", base.Imie);
        }
    }


    // Napisać klasy Kosc i Stek dziedziczące z Jedzenie
    // Metody klasy Kosc działają w następujący sposób
    //  Pogryz wypisuje na konsolę "Twarda i niedobra ta kość"
    //  Polknij wypisuje na konsolę "Kość stanęła mi w gardle"
    class Kosc : Jedzenie
    {
        public override void Pogryz()
        {
            Console.WriteLine("Twarda i niedobra ta kość");
        }

        public override void Polknij()
        {
            Console.WriteLine("Kość stanęła mi w gardle");
        }
    }

    // Metody klasy Stek działają w następujący sposób
    //  Pogryz wypisuje na konsolę "Trochę gumowy ale dobry"
    //  Polknij wypisuje na konsolę "Mniam."
    class Stek : Jedzenie
    {
        public override void Pogryz()
        {
            Console.WriteLine("Trochę gumowy ale dobry");
        }

        public override void Polknij()
        {
            Console.WriteLine("Mniam.");
        }
    }

}
