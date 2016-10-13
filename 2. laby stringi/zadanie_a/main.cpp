#include <iostream>
#include <algorithm>
#include <iterator>
#include <vector>

#include "planeta.h"

using namespace std;

//tu można dodać funkcje pomocnicze

int main()
{

    //Etap 1
    /* Aby dodawanie senatora skompilowało się należy dodać odpowiednie operatory w klasie Senator
     * lub zmodyfikować tworzenie zbioru w klasie Planeta. Oba rozwiązania są dopuszcalne
     */
    cout << endl << "Etap1 " << endl;

    Senator senators1(5, "Mieszko", "Operatia");
    Senator senators2(7, "Boleslaw", "Stochasia");
    Senator senators3(9, "Kazimierz", "Stochasia");
    Senator senators4(1, "Zygmunt", "Operatia");

    Planeta stochasia("Stochasia");


    Senator senatoro1(9, "Marvin", "Mars");
    Senator senatoro2(7, "Paragrafor", "Mars");
    Senator senatoro3(4, "E.T.", "Mars");

    Planeta operatia("Operatia");

    Planeta determia("Determia");

    Senator senatord1(10, "Alan", "Determia");

    determia.dodajSenatora(senatord1);

    stochasia.dodajSenatora(senators1);
    stochasia.dodajSenatora(senators2);
    stochasia.dodajSenatora(senators3);
    stochasia.dodajSenatora(senators4);

    operatia.dodajSenatora(senatoro1);
    operatia.dodajSenatora(senatoro2);
    operatia.dodajSenatora(senatoro3);

    stochasia.wypiszSile(cout);
    cout << endl;

    operatia.wypiszSile(cout);
    cout << endl;

    stochasia.wypiszPochodzenie(cout);
    cout << endl;

    //Etap 2
    cout << endl << "Etap 2 : usuwanie" << endl;


    Planeta nowa = stochasia; // Wywyołanie konstruktora kopiującego!
    nowa.usunSlabych(6);
    nowa.wypiszSile(cout);
    cout << endl;
    Planeta nowa2 = stochasia;
    nowa2.usunSlabych(5);
    nowa2.wypiszSile(cout);
    cout << endl << "Ponizej pusta planeta:" << endl;
    nowa2.usunSlabych(10);
    nowa2.wypiszSile(cout);
    cout << endl;


    //Etap 3
    cout << endl << "Etap3 " << endl;

    //Napisać: utworzenie wektora
    // dodanie do niego trzech planet w koolejności deklaracji w main
    // posortowanie wektora
	vector<Planeta> galaktyka;
	galaktyka.push_back(stochasia);
	galaktyka.push_back(operatia);
	galaktyka.push_back(determia);

    cout << "Sortowanie wektora: " << endl;

	vector<string> nazwy;
	transform(galaktyka.begin(), galaktyka.end(), back_inserter(nazwy),
		[](const Planeta& p) -> string {
			return p.getNazwa();
		});
	sort(nazwy.begin(), nazwy.end());
	transform(nazwy.begin(), nazwy.end(), ostream_iterator<string>(cout, " "), identity<string>());

    //Tu wypisać jako wynik same nazwy planet (w kolejności wystąpień w wektorze)
    // uzywając ostream_iterator i transform

    cout << endl;

    //Etap 5
    cout << endl << "Etap4 " << endl;

    cout << "Suma sil: " << stochasia.sumaSil() << endl;

    cout << endl;
    return 0;
}

/* Nazwy planet w programie są w rzeczywistości nazwami wysp przedstawionymi w pracy:
 * Peter J. Denning, A Tale of Two Islands (A Fable), 1980
 * http://docs.lib.purdue.edu/cstech/272/
 */

