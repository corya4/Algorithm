
#include "wordStu.h";
#include <iostream>;
using namespace std;

WordFind::WordFind() {
	fill_n(alpa_index, 26, 0);
}

void WordFind::InputIndex(char c) {
	int index = UpperLow(c);
	alpa_index[index]++;
}

int WordFind::UpperLow(char c) {
	int ASC_Org = (int)c;
	int ASC_Z = (int)'Z';
	int index =  (ASC_Org <= ASC_Z) ? ASC_Org - 65 : ASC_Org - 97;
	return index;
}

void WordFind::Find() {
	bool flag = false;
	int max = 0;
	int num = 0;
	int index = 0;

	for (int i = 0; i < 26; i++) {

		num = alpa_index[i];
		
		if (max < num) {
			max = num;
			index = i;
			flag = true;
		}else if (max == num){
			flag = false;
		}
	}

	if (flag) {
		printf("%c", (char)(65 + index));
	}else {
		printf("%c", '?');
	}

}