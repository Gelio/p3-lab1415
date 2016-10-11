#include <iostream>
#include <limits>
#include <algorithm>

#include "stationconfiguration.h"
#include "calculatechannel.h"

using namespace std;

// w tym pliku nic nie zmieniamy


#define PRINT_ARRAY(ARRAY)  for(unsigned int _i=0; _i < sizeof(ARRAY)/sizeof(ARRAY[0]) ; _i++) {\
cout << ARRAY [_i] << " ";\
}

int main()
{

    bool arr1[] = {0,1,1,1,1,
                 1,0,1,0,0,
                 1,1,0,0,0,
                 1,0,0,0,0,
                 1,0,0,0,0};
    StationConfiguration test1(5, arr1);
    int channels1[5];

    bool arr2[] =
    {0,1,1,1,1,1,
     1,0,1,1,1,1,
     1,1,0,1,1,1,
     1,1,1,0,1,1,
     1,1,1,1,0,1,
     1,1,1,1,1,0};
    StationConfiguration test2(6, arr2);

    bool arr3[5*5] = {0};

    StationConfiguration test3(5,arr3);


    int channels2[6];
    int channels3[5];

    fill_n(channels1,5,0);
    cout << "Test checkCollisions:" <<endl;
    cout << checkColisions(channels1, 0, test1) << endl;
    cout << checkColisions(channels1, 1, test1) << endl;
    cout << checkColisions(channels1, 5, test1) << endl;
    channels1[1]=1;
    cout << checkColisions(channels1, 1, test1) << endl << endl;


    auto cc1 = calculateChannelCount(test1, channels1);
    cout << "Test1" << endl << cc1.first << " " << cc1.second << endl;
    PRINT_ARRAY(channels1)
    cout << endl << endl;


    auto cc2 = calculateChannelCount(test2, channels2);
    cout <<  "test2"<< endl << cc2.first << " " << cc2.second << endl;
    PRINT_ARRAY(channels2)
    cout << endl << endl;

    auto cc3 = calculateChannelCount(test3, channels3);
    cout << "Test 3" << endl << cc3.first << " " << cc3.second << endl;
    PRINT_ARRAY(channels3)
    cout << endl << endl;

    return 0;
}

