#ifndef CALCULATECHANNEL_H
#define CALCULATECHANNEL_H

#include <utility>

// w tym pliku nic nie zmieniamy

#include "stationconfiguration.h"


using namespace std;

/**
* @brief checkColisions Sprawdza czy w podanym częściowym przypisaniu kanałów maszotom od 0 do station-1 włącznie występują
* konflikty kanałów
* @param currentChannels tablica numerów kanałów przypisanych poszczególnym masztom (i-ty element to i-ty kanał)
* @param station górny koniec zakresu masztów do sprawdzenia
* @param stationConfiguration
* @return true wtedy i tylko wtedy gdy występuje przynajmniej jedno zakłócenie
*/
bool checkColisions(int currentChannels[], int station, const StationConfiguration& stationConfiguration);
/**
* @brief calculateChannelCount Oblicza ile najmniej kanałów potrzeba aby nie było zakłóceń
* @param stationConfiguration Informacja o tym, które stacje mogą się zakłócać
* @param channels tablica o dłucości takiej jak liczba stacji. Zostaną do niej zapisane numery kanałów z optymalnego rozwiązania
* @return Para (liczba potrzebnych kanałów, optymalna liczba nieparzystych kanałów)
*/
pair<int, int> calculateChannelCount(const StationConfiguration& stationConfiguration, int channels[]);

#endif // CALCULATECHANNEL_H
