using System;

namespace PO_Lab5
{
	// Napisać abstrakcyjną klasę Jedzenie
	// a w niej publiczne abstrakcyjne bezparametrowe metody Pogryz i Polknij

	// Napisać abstrakcyjną klasę Zwierze
	// z następującymi składowymi
	// - publiczne pole Imie typu string (pole readonly)
	// - konstruktor z parametrem typu string (imię zwierzęcia)
	// - wirtualna bezparametrowa metoda Jedz
	//     wypisująca na konsolę "Zwierzę {Imie} liżę łapę"
	// - abstrakcyjna metoda Jedz z parametrem typu Jedzenie
	// - abstrakcyjna bezparanetrowa metoda DajGlos

	// Napisać klasy Pies i Kot dziedziczące z klasy Zwierze
	// obie klasy powinny zawierać konstruktor wskazujący imię zwierzęcia

	// Metody klasy Pies działają w następujący sposób:
	//  DajGlos wypisuje na konsolę "{Imie}: szczek, szczek"
	//  bezparametrowa metoda Jedz wypisuję na konsolę "{Imie}: Nie będę lizał łapy chcę coś do jedzenia"
	//  metada Jedz przyjmująca jako parametr Jedzenie - wypisuje na konsolę "{Imie} {0} połyka jedzenie: " i wywołuje metodę Polknij na parametrze.

	// Metody klasy Kot dzialają w następujący sposób:
	//  DajGlos wypisuje na konsolę "{Imie}: miau, miau"
	//  bezparametrowa metod Jedz nie jest nadpisana
	//  metada Jedz przyjmująca jako parametr Jedzenie - wypisuje na konsolę "{Imie} gryzie Jedzenie: " i wywołuje metodę Jedz na parametrze.

	// Napisać klasy Kosc i Stek dziedziczące z Jedzenie
	// Metody klasy Kosc działają w następujący sposób
	//  Pogryz wypisuje na konsolę "Twarda i niedobra ta kość"
	//  Polknij wypisuje na konsolę "Kość stanęła mi w gardle"

	// Metody klasy Stek działają w następujący sposób
	//  Pogryz wypisuje na konsolę "Trochę gumowy ale dobry"
	//  Polknij wypisuje na konsolę "Mniam."

}
