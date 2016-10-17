#define _SCL_SECURE_NO_WARNINGS

#include "calculatechannel.h"


//tu można pisać swoje implementacje (można dodpisać inne funkcje)
bool stationsCollide(const StationConfiguration& stationConfiguration, int station1, int station2);

bool checkColisions(int currentChannels[], int station, const StationConfiguration& stationConfiguration) {
	// sprawdzić czy trzeba i <= station
	for (int i = 0; i <= station; i++) {
		for (int j = 0; j < i; j++) {
			if (currentChannels[i] == currentChannels[j] && stationsCollide(stationConfiguration, i, j)) {
				return true;
			}
		}
	}
    return false;
}

pair<int, int> calculateChannelCount(const StationConfiguration& stationConfiguration, int channels[]) {
    return make_pair(0, 0);  // zmienić
}

bool stationsCollide(const StationConfiguration& stationConfiguration, int station1, int station2) {
	auto begin = stationConfiguration.interferringStations.begin();
	auto end = stationConfiguration.interferringStations.end();
	return (find(begin, end, make_pair(station1, station2)) != end ||
		find(begin, end, make_pair(station2, station1)) != end);
}
