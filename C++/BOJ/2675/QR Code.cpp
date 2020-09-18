
#include "QR Code.h";

void _printQR(int n, string str){

	for (int i = 0; i < str.length(); i++) {
	
		char c = str.at(i);
			
		for (int j = 0; j < n; j++) {
			printf("%c", c);
		}
	}
}