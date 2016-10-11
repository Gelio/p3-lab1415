#ifndef SENATOR_H
#define SENATOR_H

#include <string>

class Senator
{
private:
    int sila;
    std::string imie;
    std::string pochodzenie;
public:
    Senator(int moc, const std::string& imie, const std::string& pochodzenie);

    inline int getSila() const {return sila;}
    inline const std::string& getImie() const {return imie;}
    inline const std::string& getPochodzenie() const{return pochodzenie;}

    //tu można  dopisac metody
};

//i funkcje

#endif // SENATOR_H
