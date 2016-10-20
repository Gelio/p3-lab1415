#include "lab3.h"

#include <algorithm>
#include <iterator>

namespace lab3 {

void printVector(std::ostream &stream, const std::vector<int> &v)
{
    std::ostream_iterator<int> it(stream, " ");
    std::copy(v.begin(),v.end(), it);
    stream << std::endl;
}

//Tu implementujemy comparisonCountingSort
int comparisonCountingSort(std::vector<int> &v) {
	int counter = 0;
	std::sort(v.begin(), v.end(), [&counter](int a, int b) -> bool {
		++counter;
		return a < b;
	});

	return counter;
}

}
