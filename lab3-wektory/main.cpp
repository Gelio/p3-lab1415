#include <iostream>
#include <vector>
#include <algorithm>
#include <iterator>
#include <numeric>

#include "lab3.h"

using namespace std;

using namespace lab3;

int main() {
    srand(0xFULL);
    std::vector<int> v1(10), v2(10), v3(15);

    //Etap1
    cout << "**\nEtap1" << endl;

    // Wypełnić wektor losowymi liczbami z przedziałów:
    // v1: [3,13), v2: [0,10), v3: [1,12)
    // Koniecznie użyć algorytmu generate, jako funkcję generującą elementy
    // podać funkcję lambda wywołującą std::rand i przakształacjącą uzyskaną
    // liczbę losową na wymagany zakres

    // Tu implementujemy wypełnianie
	generate(v1.begin(), v1.end(), []() -> int {
		return rand() % 10 + 3;
	});
	generate(v2.begin(), v2.end(), []() -> int {
		return rand() % 10;
	});
	generate(v3.begin(), v3.end(), []() -> int {
		return rand() % 12 + 1;
	});
    
    printVector(cout, v1);
    printVector(cout, v2);
    printVector(cout, v3);

    //Etap 2
    cout << "**\nEtap2" << endl;

    std::vector<int> v4(v1.size()+v2.size()+v3.size());// Alokacja odpowiednio dużego wektora, mieszczącego v1, v2, v3
    const int k1 = 4 + rand() % 7;
    // Losowana wartość k1:
    // W wektorze v4 ustawić wartości kolejnych elementów na
    // elementy v1 pomnożone przez k1
    // zwiększone o k1 elementy v2
    // dzielone całkowicie przez k1 elementy v3
    // Użyć algorymu std::transform
    // Uwaga: wartość zwaracana przez transform może byc przydatna

    // Tu implementujemy etap2
	// Wartości z v1
	auto lastTransformed = transform(v1.begin(), v1.end(), v4.begin(), [k1](int val) -> int {
		return val * k1;
	});

	// Wartości z v2
	lastTransformed = transform(v2.begin(), v2.end(), lastTransformed, [k1](int val) -> int {
		return val + k1;
	});

	// Wartości z v3
	lastTransformed = transform(v3.begin(), v3.end(), lastTransformed, [k1](int val) -> int {
		return val / k1;
	});

    printVector(cout, v4);

    //Etap 3
    cout << "**\nEtap3" << endl;
    std::vector<int> v5;

    // Do wektora v5 wstawić na koniec kolejno
    // wszystkie podzielne przez 2 elementy v1, wszystkie podzielne przez 3 elementy v2,
    // wszystkie podzielne przez 5 elementy v3.
    // uzyć std::copy_if, za każdym razem użyć tego samego nazwanego wyrażenia
    // lambda przechwytującego zmienną zewnętrzną k. Wyrażenie lambda przypisać
    // do zmiennej k
    // Uwaga: może się przydać std::back_inserter i wartość zwracana przez std::copy_if
    int k;

	const auto podzielnosc = [&k](int val) -> bool { return val % k == 0; };

    k = 2;
    //operacja z v1 -> v5
	auto lastCopied = copy_if(v1.begin(), v1.end(), back_inserter(v5), podzielnosc);
    
    k = 3;
    //operacja z v2 -> v5
	lastCopied = copy_if(v2.begin(), v2.end(), lastCopied, podzielnosc);
    
    k = 5;
    //operacja z v3 -> v5
	lastCopied = copy_if(v3.begin(), v3.end(), lastCopied, podzielnosc);

    printVector(cout, v5);

    //Etap 4
    cout << "**\nEtap4" << endl;

    // Wypisać odpowiednie wyniki działań. Wykorzystać algorytm std::accumulate i funkcje lambda
    // Ad. v3: w dokumentacji accumulate zwrócić uwagę co dokładnie jest podawane jako pierwszy a co jako drugi
    // argument funkcji akumulującej
    // Zamienić "???" odpowiednimi wywołaniami std::accumulate
	int factorial[14];
	int iloczyn = 1;
	for (int i = 1; i < 14; i++) {
		iloczyn *= i;
		factorial[i] = iloczyn;
	}

	cout << "iloczyn elementów  v1: " << accumulate(v1.begin(), v1.end(), 1, [](int iloczyn, int element) -> int { return iloczyn * element; }) << endl;
    cout << "suma elementów v2: " << accumulate(v2.begin(), v2.end(), 0, [](int suma, int element) -> int { return suma + element; }) << endl;
    cout << "suma silni elementów v3: " << accumulate(v3.begin(), v3.end(), 0, [&factorial](int suma, int element) -> int { return suma + factorial[element]; }) << endl;

    //Etap5
    cout << "**\nEtap5" << endl;

    // Zaimplementować comparisonCountingSort, szczegóły w lab3.h
    // następnie odkomentować poniższy fragment
    
    cout << "v1: " << comparisonCountingSort(v1) << ", v2: "
         << comparisonCountingSort(v2)
         << ", v3: " << comparisonCountingSort(v3) << endl;

    return 0;
}

