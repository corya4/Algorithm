#include <iostream>
#include <string>
#include "r_comp.h";

using namespace std;

class Compare {
	int x = 0;
	int y = 0;

public:
	void compareInt();
	void swapInt(int n, int c);

};

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

int main(void) {
	int x, y;
	cin >> x >> y;
	Compare c;
	c.swapInt(x, 1); c.swapInt(y, 0);
	c.compareInt();
}