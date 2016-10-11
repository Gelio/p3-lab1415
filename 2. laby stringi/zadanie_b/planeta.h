#ifndef PLANETA_H
#define PLANETA_H

#include <vector>
#include <ostream>

#include "senator.h"

class Planeta
{
private:
    const std::string nazwa;
    std::vector<Senator> senat;
public:
    Planeta(std::string nazwa);

    void dodajSenatora(const Senator& senator);

    const std::string& getNazwa() const { return nazwa;}

    void wypiszSile(std::ostream& out) const;
    void wypiszPochodzenie(std::ostream& out) const;

    void usunIdentyczneSily();

    int pojedynekSenatow(const Planeta& b) const;
    //tu mo¿na  dopisac metody
};

//i funkcje

#endif // PLANETA_H
