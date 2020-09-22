#include <iostream>
#include "DialTaken.h";

using namespace std;



int main(void) {
	int time = 0;
	string word;
	getline(cin, word, '\n');
	Dial D;

	for (int i = 0; i < word.length(); i++) {
		time += D.Taken_Time(word.at(i));
	}

	cout << time;
}