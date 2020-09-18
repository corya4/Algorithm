
#include <iostream>
#include "FindAlph.h"

Alpa::Alpa() {
	GetAlpa();
}

void Alpa::GetAlpa() {
	for (int i = 0; i < 26; i++) {
		Alpa::alpa[i] = (char)(97 + i);
	}
}

void Alpa::GetIndex(char str[]) {
	int answer = -1;

	for (int i = 0; i < 26; i++) {
		char c = Alpa::alpa[i];

		for (int j = 0; j < 100; j++) {
			if (str[j] == c) {
				answer = j;
				break;
			}
		}

		if (i != 25) {
			cout << answer << " ";
		}
		else {
			cout << answer;
		}
			
		answer = -1;
	}
}