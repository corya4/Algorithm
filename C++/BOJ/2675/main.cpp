#include <iostream>
#include "QR Code.h";

using namespace std;


int main(void) {
	
	int cnt;
	int r;
	string str;

	cin >> cnt;

	while(cnt--){
		cin >> r >> str;
		_printQR(r, str);
		cout << '\n';
	}
}