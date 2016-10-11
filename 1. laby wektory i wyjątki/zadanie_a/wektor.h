
#ifndef _WEKTOR_H_
#define _WEKTOR_H_

#include <iostream>

using namespace std;

// Tu dopisac klase Vect_exceptiom pochodna od exception.
// Zdefiniowac konstruktor Wektor_exceptiom(const char *const message), ktorego parametr opisuje przyczyne zgloszenia wyjatku



template <class T> class Wektor
    {

//  W tej klasie wolno jedynie dodawac nowe skladowe
//  Nie wolno usuwac istniejacych ani modyfikowac ich naglowkow !!!

    public:

    ~Wektor()
        {
        delete[] wsp;
        }

    T operator[](int n) const
        {
        // dodac zgloszenie wyjatku przy niepoprawnym indeksie
        return wsp[n];
        }

    private:

    T*  wsp;

    };

#endif   // _WEKTOR_H_
