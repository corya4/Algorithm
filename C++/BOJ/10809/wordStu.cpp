
#include "wordStu.h";
#include <iostream>;
using namespace std;

WordFind::WordFind() {
	alpa_index[26] = { 0, };
}

void WordFind::InputIndex(char c) {
	int index = UpperLow(c);
	cout << index;
	cout << '\n';

	++alpa_index[index];
	
	//cout << &alpa_index[index];
	//cout << "\n";
}

int WordFind::UpperLow(char c) {
	int ASC_Org = (int)c;
	int ASC_Z = (int)'Z';
	return (ASC_Org <= ASC_Z) ? ASC_Org - 65 : ASC_Org - 97;
}

void WordFind::Find() {
	bool flag = false;
	int max = 0;
	int num = 0;

	for (int i = 0; i < 26; i++) {

		&num <= &alpa_index[i];

		//cout << num;
		//cout << '\n';

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

	//free(alpa_index);

}