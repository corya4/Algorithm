#include <iostream>
#include "BEP.h";
using namespace std;

int main(void) {

	int total, cost, price;
	cin >> total >> cost >> price;
	cout << BreakEventPoint(total, cost, price);
}

