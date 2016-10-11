
#include <iostream>
#include "vect.h"

using namespace std;

void main()
    {
    int tab1[] = { 1, 5, 7 };
    int tab2[] = { -3, 0, -1, 7 };
    double tabd[] = { 0.5, -1.0, 0.75 };

    cout << endl << "*** Part I ***" << endl << endl;

    //Vect<int> v1(1);
    //const Vect<int> v2(3,tab1);
    //const Vect<int> v3(4,tab2);
    //Vect<int> v4=v2;
    //Vect<double> wd(3,tabd);

    //cout << "v1: " << v1 << endl;
    //cout << "v2: " << v2 << endl;
    //cout << "v3: " << v3 << endl;
    //cout << "v4: " << v4 << endl;
    //v1=v3;
    //cout << "v1: " << v1 << endl;
    //cout << "v1 size: " << v1.Size() << endl;
    //cout << "v4 size: " << v4.Size() << endl;
    //cout << "wd: " << wd << endl;

    cout << endl << "*** Part II ***" << endl << endl;

    //v1=5*v3;
    //cout << "v1: " << v1 << endl;
    //cout << "v3: " << v3 << endl;
    //v1+=v3;
    //cout << "v1: " << v1 << endl;
    //cout << "v3: " << v3 << endl;
    //v1=v4+v2;
    //cout << "v1: " << v1 << endl;
    //cout << "v4: " << v4 << endl;
    //v1[2]=0;
    //cout << "v1: " << v1 << endl;
    //cout << "v2[0]: " << v2[0] << endl;
    //int x;
    //x=v1*v2;
    //cout << "x:     " << x << endl;

    cout << endl << "*** Part III ***" << endl << endl;

    // wylapac wyjatki generowane przez ponizsze wyrazenia
    // do wypisywania komunikatow wykorzystac metode what z klasy exception
    // Lapac tylko wyjatki klasy Vect_exceptiom

    //cout << "v2+v3: " << v2+v3 << endl;
    //cout << "v2*v3: " << v2*v3 << endl;
    //cout << "v1[-1]: " << v1[-1] << endl;
    //cout << "v2[10]: " << v2[10] << endl;

    cout << endl << "*** End ***" << endl << endl;

    // tu nie wolno dopisywac zadnego getchar(), system("pause")
    // ani nic co zatrzyma wykonanie funkcji main
    }

