#define _SCL_SECURE_NO_WARNINGS
#include <list>
#include <algorithm>
#include <iterator>
#include <iostream>
#include <numeric>
#include "calculatechannel.h"


//tu można pisać swoje implementacje (można dodpisać inne funkcje)
bool stationsCollide(const StationConfiguration& stationConfiguration, int station1, int station2);
list<vector<int>> generatePermutations(vector<int> base, int offset, int maxNumber);
int calculateChannelDifference(const StationConfiguration& stationConfiguration, const vector<int>& permutation);

bool checkColisions(int currentChannels[], int station, const StationConfiguration& stationConfiguration) {
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
	int channelsCount = 1,
		channelsDifference = 0,
		stationCount = stationConfiguration.stationCount;
	vector<int> bestPermutation;
	for (int i = 0; i < stationCount; i++) {
		channels[i] = 0;
	}

	for (channelsCount = 1; channelsCount <= stationCount; channelsCount++) {	
		list<vector<int>> permutations = generatePermutations(vector<int>(channels, channels + stationCount), 0, channelsCount);
		remove_if(permutations.begin(), permutations.end(), [&channels, &stationCount, &stationConfiguration](vector<int> permutation) -> bool {
			for (int i = 0; i < permutation.size(); i++) {
				channels[i] = permutation[i];
			}
			return checkColisions(channels, stationCount, stationConfiguration);
		});

		if (permutations.begin() == permutations.end()) {
			continue;
		}

		channelsDifference = calculateChannelDifference(stationConfiguration, permutations.front());
		bestPermutation = accumulate(permutations.begin(), permutations.end(), permutations.front(), [&](vector<int> bestPermutation, vector<int> permutation) -> vector<int> {
			int currentCost = calculateChannelDifference(stationConfiguration, permutation);
			if (currentCost < channelsDifference) {
				channelsDifference = currentCost;
				return permutation;
			}

			return bestPermutation;
		});
		break;
	}

	for (int i = 0; i < bestPermutation.size(); i++) {
		channels[i] = bestPermutation[i];
	}

    return make_pair(channelsCount, channelsDifference);
}

bool stationsCollide(const StationConfiguration& stationConfiguration, int station1, int station2) {
	auto begin = stationConfiguration.interferringStations.begin();
	auto end = stationConfiguration.interferringStations.end();
	return (find(begin, end, make_pair(station1, station2)) != end ||
		find(begin, end, make_pair(station2, station1)) != end);
}

list<vector<int>> generatePermutations(vector<int> base, int offset, int maxNumber) {
	if (offset == base.size()) {
		return list<vector<int>>();
	}

	list<vector<int>> totalPermutations;
	for (int i = 0; i <= maxNumber; i++) {
		base[offset] = i;
		totalPermutations.push_back(base);
		list<vector<int>> permutations = generatePermutations(base, offset + 1, maxNumber);
		copy(permutations.begin(), permutations.end(), back_inserter(totalPermutations));
	}

	totalPermutations.unique([](const vector<int>& v1, const vector<int>& v2) -> bool {
		return v1 == v2;
	});
	return totalPermutations;
}

int calculateChannelDifference(const StationConfiguration& stationConfiguration, const vector<int>& permutation) {
	return accumulate(stationConfiguration.interferringStations.begin(), stationConfiguration.interferringStations.end(), 0,
		[&permutation](int sum, pair<int, int> stationSet) -> int {
			return sum + abs(permutation[stationSet.first] - permutation[stationSet.second]);
	});
}