
#include "wordCnt.h";
#include <iostream>;
using namespace std;

int CountWord(string str) {

	int cnt = 0;
	bool flag = true;

	for (int i = 0; i < str.length(); i++) {

		if (!(65 <= str[i] && str[i] <= 90) && !(97 <= str[i] && str[i] <= 122) && str[i] != ' ') break;

		if (str[i] != ' ') {
			if (flag) cnt++;
			flag = false;
		}
		else {
			flag = true;
		}

	}

	return cnt;
}