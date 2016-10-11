#ifndef STATIONCONFIGURATION_H
#define STATIONCONFIGURATION_H

#include <utility>

// w tym pliku nic nie zmieniamy

class StationConfiguration
{
public:
    //liczba stacji
    const int stationCount;
    // tablica stationCount^2 elementów zawierajaca informację o możliwych zakłóceniach. Interpretowana jako
    // macierz stacionCount x stationCount, musi być symetryczna
    bool* interferringStations;
    StationConfiguration(int stationCount, bool* interferringStations);

   //Podaje informację czy dana para masztów może się zakłócać
    inline bool checkInterferrence(int stationA, int stationB) const {return interferringStations[stationCount*stationA+stationB];}
};

#endif // STATIONCONFIGURATION_H
