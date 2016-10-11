#include <iostream>
#include <algorithm>
#include <iterator>
#include <set>

#include "planeta.h"

using namespace std;


//tu można dodac funkcje pomocnicze

int main()
{

    //Etap 1
    /* Aby dodawanie senatora skompilowało się należy dodać odpowiednie operatory w klasie Senator
     * lub zmodyfikować tworzenie zbioru w klasie Planeta. Oba rozwiązania są dopuszcalne
     */

  /*
    Senator senators1(5, "Mieszko", "Operatia");
    Senator senators2(7, "Boleslaw", "Stochasia");
    Senator senators3(9, "Kazimierz", "Stochasia");
    Senator senators4(9, "Zygmunt", "Stochasia");

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
  */

     //Etap 2
  /*
    cout << "Etap 2 -- najdluzszy spojny podciag rosnacy" << endl << "Stochasia: " << stochasia.podciagRosnacy() << endl
    << "Operatia: " << operatia.podciagRosnacy() << endl;*/

    //Etap 3
  /*
    cout << "Etap 3 : usuwanie" << endl;
    Planeta nowa = stochasia; // Wywyołanie konstruktora kopiującego!
    nowa.usunIdentyczneSily();
    nowa.wypiszSile(cout);
    cout << endl;
    nowa.dodajSenatora(senators1);
    nowa.dodajSenatora(senators1);
    nowa.dodajSenatora(senators2);
    nowa.dodajSenatora(senators2);
    nowa.dodajSenatora(senators3);
    nowa.dodajSenatora(senators3);
    nowa.wypiszSile(cout);
    cout << endl;
    nowa.usunIdentyczneSily();
    nowa.wypiszSile(cout);
    cout << endl;
  */
    //Etap 4

    
    cout << "Etap4, posortowany zbior: " << endl;

    // Utworzenie zbioru
    // Dodanie trzech planet
    // wypanie wyniku z uzyciem ostream_iterator i tranform. Jako wynik należy wypisać nazwy planet
    // w kolejności w jakiej są w zbiorze.
    
    cout << endl;

    //Etap 5
    /*
    cout << "Pojedynek 1: " << stochasia.pojedynekSenatow(operatia) << endl;
    cout << "Pojedynek 2: " << stochasia.pojedynekSenatow(determia) << endl;
    cout << "Pojedynek 3: " << determia.pojedynekSenatow(stochasia) << endl;
    */
    return 0;
}

/* Nazwy planet w programie są w rzeczywistości nazwami wysp przedstawionymi w pracy:
 * Peter J. Denning, A Tale of Two Islands (A Fable), 1980
 * http://docs.lib.purdue.edu/cstech/272/
 */

