
#ifndef _Vect_H_
#define _Vect_H_

#include <iostream>

using namespace std;

// Tu dopisac klase Vect_exceptiom pochodna od exception.
// Zdefiniowac kondtruktor Vect_exceptiom(const char *const message), ktorego parametr opisuje przyczyne zgloszenia wyjatku



template <class T> class Vect
    {

//  W tej klasie wolno jedynie dodawac nowe skladowe
//  Nie wolno usuwac istniejacych ani modyfikowac ich naglowkow !!!

    public:

    ~Vect()
        {
        delete[] w;
        }

    T operator[](int n) const
        {
        // dodac zgloszenie wyjatku przy niepoprawnym indeksie
        return w[n];
        }

    private:

    T*  w;

    };

#endif   // _Vect_H_
