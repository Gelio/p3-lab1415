
#include <iostream>
#include "wektor.h"

using namespace std;

void main()
    {
    int tab3[] = { 2, 3, 4 };
    int tab4[] = { -2, -1, 0, 5 };
    double tabd[] = { 0.5, -1.0, 0.75 };

    cout << endl << "*** Etap I ***" << endl << endl;

    //Wektor<int> w1(1);
    //const Wektor<int> w2(3,tab3);
    //const Wektor<int> w3(4,tab4);
    //Wektor<int> w4=w2;
    //Wektor<double> wd(3,tabd);

    //cout << "w1: " << w1 << endl;
    //cout << "w2: " << w2 << endl;
    //cout << "w3: " << w3 << endl;
    //cout << "w4: " << w4 << endl;
    //w1=w3;
    //cout << "w1: " << w1 << endl;
    //cout << "rozm. w1: " << w1.Rozm() << endl;
    //cout << "rozm. w4: " << w4.Rozm() << endl;
    //cout << "wd: " << wd << endl;

    cout << endl << "*** Etap II ***" << endl << endl;

    //w1=w2+5;
    //cout << "w1: " << w1 << endl;
    //cout << "w2: " << w2 << endl;
    //w4+=5;
    //cout << "w4: " << w4 << endl;
    //w4=w1+w2;
    //cout << "w4: " << w4 << endl;
    //w1[2]=0;
    //cout << "w1: " << w1 << endl;
    //cout << "w2[0]: " << w2[0] << endl;
    //int x;
    //x=w1*w2;
    //cout << "x:     " << x << endl;

    cout << endl << "*** Etap III ***" << endl << endl;

    // wylapac wyjatki generowane przez ponizsze wyrazenia
    // do wypisywania komunikatow wykorzystac metode what z klasy exception
    // Lapac tylko wyjatki klasy Wektor_exceptiom

    //cout << "w2+w3: " << w2+w3 << endl;
    //cout << "w2*w3: " << w2*w3 << endl;
    //cout << "w1[-1]: " << w1[-1] << endl;
    //cout << "w2[10]: " << w2[10] << endl;

    cout << endl << "*** Koniec ***" << endl << endl;

    // tu nie wolno dopisywac zadnego getchar(), system("pause")
    // ani nic co zatrzyma wykonanie funkcji main
    }

