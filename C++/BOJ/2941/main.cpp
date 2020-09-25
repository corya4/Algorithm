#include <iostream>

using namespace std;

class CroatiaFind {

public:
	int CntFind(string word, int length, string token, int index) {

		if (length < index) return 0;

		int v = (int)word.find(token, index);
		if (v >= 0) {
			return 0;
		}

		return (CntFind(word, length, token, v)) + 1;
	}
};


int main(void) {
	string Croatia[] = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
	CroatiaFind Find;
	string word;
	cin >> word;

	int cnt, cTmp;
	cnt = word.length();
	cTmp = cnt;

	for (int i = 0; i < word.length(); i++) {
		int c = Find.CntFind(word, cTmp, Croatia[i], 0);
		if (c) {
			cnt -= c;
		}
			
	}
	
	cout << cnt;
}

