
#define _CRT_SECURE_NO_WARNINGS
#include <algorithm>
#include <iterator>
#include "Graph.h"

// Tu dopisz implementacje
bool Graph::AddNode(int n) {
	// false gdy juz jest
	if (this->nodes.find(n) != this->nodes.end()) {
		return false;
	}

	this->nodes.insert(make_pair(n, map<int, int>()));
	return true;
}

bool Graph::AddEdge(int n1, int n2, int w) {
	// false gdy krawedz juz jest lub nie ma ktoregos z wierzcholkow lub n1==n2
	if (n1 == n2) {
		return false;
	} else if (this->nodes.find(n1) == this->nodes.end()) {
		return false;
	} else if (this->nodes.find(n2) == this->nodes.end()) {
		return false;
	}

	map<int, int> *edges = &(*this->nodes.find(n1)).second;
	if ((*edges).find(n2) != (*edges).end()) {
		return false;
	}

	(*edges).insert(make_pair(n2, w));
	return true;
}

bool Graph::DelNode(int n) {
	// false gdy nie ma (usuwa wszystkie "przylegle" krawedzie)
	auto found = this->nodes.find(n);
	if (found == this->nodes.end()) {
		return false;
	}

	this->nodes.erase(n);
	for_each(this->nodes.begin(), this->nodes.end(),
		[&n](pair<const int, map<int, int>>& node) {
			node.second.erase(n);
	});

	return true;
}

bool Graph::DelEdge(int n1, int n2) {
	// false gdy krawedzi nie ma lub nie ma ktoregos z wierzcholkow lub n1==n2
	if (n1 == n2) {
		return false;
	}
	else if (this->nodes.find(n1) == this->nodes.end()) {
		return false;
	}
	else if (this->nodes.find(n2) == this->nodes.end()) {
		return false;
	}

	map<int, int> *edges = &(*this->nodes.find(n1)).second;
	if ((*edges).find(n2) == (*edges).end()) {
		return false;
	}

	(*edges).erase(n2);
	return true;
}

Graph Graph::Reverse(const Graph& g) {
	// tworzy Graph z odworoconymi kierunkami krawedzi
	return Graph();
}

ostream& operator<<(ostream &out, const Graph& g) {
	for_each(g.nodes.begin(), g.nodes.end(),
		[&out](const pair<int, map<int, int>>& node) {
			out << node.first << ": ";
			
			for_each(node.second.begin(), node.second.end(), [&out](const pair<int, int>& edge) {
				out << "(" << edge.first << "," << edge.second << ") ";
			});

			out << ";" << endl;
	});
	return out;
}

istream& operator>>(istream &in, Graph& g) {
	// format danych wejsciowych taki jak wyjscie poprzedniej funkcji
	return in;
}