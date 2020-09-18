
#include "FindAlph.h";
#include <iostream>

using namespace std;

int main(void) {
	char cArr[100] = {'*',};

	string value;
	cin >> value;
	
	for (int i = 0; i < value.length(); i++) {
		cArr[i] = value.at(i);
	}

	Alpa alpa;
	alpa.GetIndex(cArr);
}
