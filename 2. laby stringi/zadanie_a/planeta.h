#ifndef PLANETA_H
#define PLANETA_H

#include <set>
#include <ostream>

#include "senator.h"

class KomparatorSenatorow {
public:
	bool operator()(const Senator& s1, const Senator& s2);
};

class Planeta
{
private:
  // nie modyfikujemy definicji tego pola
    const std::string nazwa;

    std::set<Senator, KomparatorSenatorow> senat;
public:
	Planeta(const std::string& nazwa) : nazwa(nazwa) { };

    void dodajSenatora(const Senator& senator);

    const std::string& getNazwa() const { return nazwa;}

    void wypiszSile(std::ostream& out) const;
    void wypiszPochodzenie(std::ostream& out) const;

    void usunSlabych(int sila);

    int sumaSil() const;

    // mozna dodać metody pomocnicze
};


// i funkcje pomocnicze

#endif // PLANETA_H
