#include <iostream>
#include "Comb.h";
using namespace std;

int main(void) {
	int room;
	cin >> room;
	int v = FindCnt(1, 1, room);
	cout << v;
}

