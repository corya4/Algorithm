
#include "wordStu.h";
#include <iostream>;
using namespace std;

WordFind::WordFind() {
	alpa_index[26] = { 0, };
}

void WordFind::InputIndex(char c) {
	int index = UpperLow(c);
	//cout << index;
	//cout << "\n";
	//alpa_index[index];
}

int WordFind::UpperLow(char c) {
	return (c < 'Z') ? c - 65 : c - 97;
}

void WordFind::Find() {
	bool flag = false;
	int max = 0;
	int num = 0;

	for (int i = 0; i < 26; i++) {
		num = alpa_index[i];

		cout << num;
		cout << "\n";

		if (max < num) {
			max = num;
			flag = true;
		}else if (max == num){
			flag = false;
		}
	}

	if (flag) {
		printf("%c", (char)(65 + max));
	}else {
		printf("%s", "?");
	}

	free(alpa_index);

}