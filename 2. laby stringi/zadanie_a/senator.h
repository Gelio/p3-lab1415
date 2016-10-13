#ifndef SENATOR_H
#define SENATOR_H

#include <string>

class Senator
{
private:
  // nie wolno zmieniać deklaracji pól klasy
    const int sila;
    const std::string imie;
    const std::string pochodzenie;
public:
	Senator(int moc, std::string imie, std::string pochodzenie) : sila(moc), imie(imie), pochodzenie(pochodzenie) { };

    inline int getSila() const {return sila;}
    inline const std::string& getImie() const {return imie;}
    inline const std::string& getPochodzenie() const{return pochodzenie;}

    // tu można dodac swoje metody
};

// mozna też dodać funkcje pomocznicze

#endif // SENATOR_H
