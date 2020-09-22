
#include "DialTaken.h";
#include <iostream>;
using namespace std;


int Dial::Taken_Time(char c) {
	int tmp = (int)c - 65;

	if (0 <= tmp && tmp <= 14) {
		tmp = (tmp / 3) + 3;

	}
	else if (tmp <= 18) {

		tmp = 8;
	}
	else if (tmp <= 21) {

		tmp = 9;
	}
	else if (22 <= tmp && tmp <= 25) {

		tmp = 10;
	}
	else {

		tmp = 0;
	}

	return tmp;
}


void Compare::swapInt(int n, int c) {
	string str = to_string(n);
	string R;
	bool flag = false;
	for (int i = str.length() - 1; i >= 0; i--) {
		char tmp = str.at(i);

		if (tmp != '0' || flag) {
			R += tmp;
			flag = true;
		}
	}

	if (c == 1) x = stoi(R);
	else y = stoi(R);

}