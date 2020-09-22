#include <iostream>
#include <string>
#include "wordCnt.h";

using namespace std;

int main(void) {
	string word;
	getline(cin, word);
	cout << CountWord(word) << endl;
}