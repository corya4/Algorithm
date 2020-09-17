
#include <iostream>
#include <string>
#include "FindAlph.h"

using namespace std;

Alpa::Alpa() {
	GetAlpa();
}

void Alpa::GetAlpa() {

	for (int i = 0; i < 24; i++) {
		alpa[i] = (char)(48 + i);
	}

}

void Alpa::GetIndex(string str) {

	int answer = -1;

	for (int i = 0; i < str.length(); i++){
		char c = str.at(i);

		for (int j = 0; j < 24; j++) {
			if (alpa[j] == c) {
				answer = j;
			}
		}

		cout << answer + " ";
		answer = -1;
	}

}