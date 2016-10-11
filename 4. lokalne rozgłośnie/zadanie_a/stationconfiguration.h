#ifndef STATIONCONFIGURATION_H
#define STATIONCONFIGURATION_H

#include <utility>
#include <vector>

// w tym pliku nic nie zmieniamy

class StationConfiguration
{
public:
    //liczba stacji
    const int stationCount;
    //informacja o możliwych zakłóceniach
    const std::vector<std::pair<int, int> > interferringStations;
    StationConfiguration(int stationCount, const std::vector<std::pair<int, int> > interferringStations);
};

#endif // STATIONCONFIGURATION_H
