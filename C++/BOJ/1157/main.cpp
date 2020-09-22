#include <iostream>
#include "wordStu.h";

using namespace std;

int main(void) {

	WordFind wf;
	string str;
	
	cin >> str;
	
	for (int i = 0; i < str.length(); i++) {
		wf.InputIndex(str.at(i));
	}

	wf.Find();
	
}