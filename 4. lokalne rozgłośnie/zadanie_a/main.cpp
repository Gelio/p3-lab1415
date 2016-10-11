#include <iostream>
#include <limits>

#include "stationconfiguration.h"
#include "calculatechannel.h"

using namespace std;

// w tym pliku nic nie zmieniamy


#define PRINT_ARRAY(ARRAY)  for(unsigned int _i=0; _i < sizeof(ARRAY)/sizeof(ARRAY[0]) ; _i++) {\
cout << ARRAY [_i] << " ";\
}

#define ARRAY_LENGTH(ARRAY) (sizeof(ARRAY)/sizeof(ARRAY[0]))

int main()
{
    pair<int, int> arr1[] = {make_pair(0,1), make_pair(0,2), make_pair(0,3), make_pair(0,4), make_pair(1,2)};
    StationConfiguration test1(5, std::vector<pair<int, int> > (arr1, arr1+ARRAY_LENGTH(arr1)));
    int channels1[5];

    pair<int, int> arr2[] = {make_pair(0,1), make_pair(0,2), make_pair(0,3), make_pair(0,4), make_pair(0,5),
                             make_pair(1,2), make_pair(1,3), make_pair(1,4), make_pair(1,5),
                             make_pair(2,3), make_pair(2,4), make_pair(2,5),
                             make_pair(3,4), make_pair(3,5),
                             make_pair(4,5)
                         };
    StationConfiguration test2(6, std::vector<pair<int, int> >(arr2, arr2+ARRAY_LENGTH(arr2)));

    StationConfiguration test3(5, std::vector<pair<int, int> >());


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

