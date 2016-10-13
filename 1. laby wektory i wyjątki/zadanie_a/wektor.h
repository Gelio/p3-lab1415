
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
		Wektor(int _n, T source[] = nullptr) { this->init(_n, source);  };
		Wektor(const Wektor<T>& w) { this->init(w.n, w.wsp);  };
		int Rozm() const { return n; }

		template <class T>
		friend ostream& operator<<(ostream& os, const Wektor<T>& w);
		
		Wektor<T>& operator=(const Wektor<T>& source);

		template <class T>
		friend Wektor<T> operator+(const Wektor<T>& w, int n);
		Wektor<T>& operator+=(int n);

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
	int n;
	void init(int _n, T source[] = nullptr);

    };

template <class T>
void Wektor<T>::init(int _n, T source[]) {
	this->n = _n;
	this->wsp = new T[this->n];

	if (!source) {
		for (int i = 0; i < n; i++) {
			(this->wsp)[i] = 0;
		}
	}
	else {
		for (int i = 0; i < n; i++) {
			(this->wsp)[i] = source[i];
		}
	}
}

template <class T>
ostream& operator<<(ostream& os, const Wektor<T>& w) {
	os << "[";
	for (int i = 0; i < w.n; i++) {
		os << w.wsp[i];
		if (i < w.n - 1) {
			os << ",";
		}
	}
	return os << "]";
}

template <class T>
Wektor<T>& Wektor<T>::operator=(const Wektor<T>& source) {
	delete[] this->wsp;
	init(source.n, source.wsp);
	return *this;
}


template <class T>
Wektor<T> operator+(const Wektor<T>& w, int n) {
	Wektor<T> wynik = w;
	for (int i = 0; i < w.n; i++) {
		wynik[i] += n;
	}

	return wynik;
}

template <class T>
Wektor<T>& Wektor<T>::operator+=(int n) {

}

#endif   // _WEKTOR_H_