
#include "r_comp.h";
#include <iostream>;
using namespace std;

void Compare::compareInt() {
	cout << ((x > y) ? x : y);
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