#include <algorithm>
#include <numeric>
#include "planeta.h"


using namespace  std;

//tu implementacje metod z planeta.h
bool KomparatorSenatorow::operator()(const Senator& s1, const Senator& s2) {
	if (s1.getSila() > s2.getSila()) {
		return 1;
	}
	else if (s1.getSila() < s2.getSila()) {
		return 0;
	}
	else {
		return s1.getImie() > s2.getImie();
	}
}


void Planeta::dodajSenatora(const Senator& senator) {
	this->senat.insert(senator);
}

void Planeta::wypiszSile(std::ostream& out) const {
	std::for_each(this->senat.begin(), this->senat.end(),
		[&out](const Senator& s) -> void { out << s.getImie() << " " << s.getSila() << ", "; });
}

void Planeta::wypiszPochodzenie(std::ostream& out) const {
	std::for_each(this->senat.begin(), this->senat.end(),
		[&out](const Senator& s) -> void { out << s.getImie() << ":" << s.getPochodzenie() << ", "; });
}

void Planeta::usunSlabych(int sila) {
	set<Senator>::iterator znaleziony = this->senat.end();
	while ((znaleziony = find_if(this->senat.begin(), this->senat.end(), [&sila](const Senator& s) -> bool { return s.getSila() < sila; })) != this->senat.end()) {
		this->senat.erase(*znaleziony);
	}
}

int Planeta::sumaSil() const {
	return accumulate(this->senat.begin(), this->senat.end(), 0, [](int suma, const Senator& s) -> int { return suma + s.getSila(); });
}