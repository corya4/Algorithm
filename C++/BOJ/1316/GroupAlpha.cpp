#include "GroupAlpha.h";

bool GroupWord(string word) {

	char cTmp = '0';
	vector<char> vt;
	vector<char>::iterator it;
	int length = word.length();
	int dLen = 0;

	for (int i = 0; i < length; i++) {

		if (cTmp == word.at(i)) continue;

		cTmp = word.at(i);
		char& rChar = cTmp;

		if (vt.size() != 0) {

			for (int j = 0; j < dLen; j++) {
				if (vt[j] == cTmp) {
					return false;
				}
			}

		}

		vt.push_back(cTmp);
		dLen++;
	}

	return true;
}