
#include "GroupAlpha.h";

int main(void) {

	int cnt, value = 0;
	string word;

	cin >> cnt;

	while (cnt--) {
		cin >> word;
		if (GroupWord(word)) value++;
	}

	cout << value;
}

