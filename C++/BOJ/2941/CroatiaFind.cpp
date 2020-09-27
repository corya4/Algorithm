#include "CroatiaFind.h";



int CroatiaFind::CntFind(string word, int length, string token, int index) {
	if (length <= index) return 0;

	int v = (int)word.find(token, index);
	if (v < 0) {
		return 0;
	}

	int t = CntFind(word, length, token, v + 1);
	return t + 1;

};

